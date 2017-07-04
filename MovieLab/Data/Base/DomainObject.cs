using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BoardGameLibrary.Data.Base
{
  public class DomainObject : IEquatable<DomainObject>, INotifyPropertyChanged, IDomainObject
  {
    public DomainObject()
    {
      Id = Guid.NewGuid();
    }

    [XmlAttribute]
    public Guid Id { get; set; }

    [XmlIgnore]
    RepositoryBase IDomainObject.Repository { get; set; }

    protected T GetById<T>(Guid id) where T : DomainObject
    {
      IDomainObject domainObject = this;
      if (domainObject.Repository == null) return null;
      return domainObject.Repository.GetById<T>(id);
    }

    protected T GetById<T>(Guid? id) where T : DomainObject
    {
      return id.HasValue ? GetById<T>(id.Value) : null;
    }

    protected Guid? NullIfOrphaned(Guid? id)
    {
      if (id.HasValue == false) return null;
      IDomainObject domainObject = this;
      if (domainObject.Repository == null) return null;
      if (domainObject.Repository.Exists(id.Value) == false) return null;
      return id.Value;
    }

    [XmlIgnore]
    public bool IsRepositoryObject
    {
      get
      {
        IDomainObject domainObject = this;
        return domainObject.Repository != null;
      }
    }

    #region Equality

    public static bool Equals(DomainObject d1, DomainObject d2)
    {
      // check for both null (cast to object or recursive loop)
      if ((object)d1 == null && (object)d2 == null)
      {
        return true;
      }

      // check for either of them == to null
      if ((object)d1 == null || (object)d2 == null)
      {
        return false;
      }

      return d1.Id.Equals(d2.Id);
    }

    public bool Equals(DomainObject other)
    {
      return Equals(this, other);
    }

    public override bool Equals(object obj)
    {
      return Equals(this, obj as DomainObject);
    }

    public static bool operator ==(DomainObject d1, DomainObject d2)
    {
      return Equals(d1, d2);
    }

    public static bool operator !=(DomainObject d1, DomainObject d2)
    {
      return Equals(d1, d2) == false;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }

    #endregion

    #region IPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, params string[] propertyNames)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        Array.ForEach(propertyNames, OnPropertyChanged);
        return true;
    }

    #endregion
  }
}