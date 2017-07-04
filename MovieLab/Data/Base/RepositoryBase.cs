using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace BoardGameLibrary.Data.Base
{
  public abstract class RepositoryBase : INotifyPropertyChanged
  {
    private readonly Dictionary<Guid, IDomainObject> _itemsById = new Dictionary<Guid, IDomainObject>();
    private readonly Dictionary<Type, IList> _bindingLists = new Dictionary<Type, IList>();

    [XmlIgnore]
    public bool IsModified { get; set; }

    public void AddBindingList<T>(Type type, BindingList<T> bindingList) where T : DomainObject
    {
      _bindingLists.Add(type, bindingList);
      bindingList.ListChanged += OnListChanged;
    }

    public void Add(DomainObject item)
    {
      if (item == null) throw new ArgumentNullException("item");
      if (_itemsById.ContainsKey(item.Id)) throw new ArgumentException("Item already exists");

      IList bindingList = _bindingLists[item.GetType()];
      bindingList.Add(item);
    }

    public bool Remove(DomainObject item)
    {
      if (item == null) throw new ArgumentNullException("item");

      IList bindingList = _bindingLists[item.GetType()];

      bindingList.Remove(item);
      IDomainObject removedItem = item;
      removedItem.Repository = null;
      _itemsById.Remove(removedItem.Id);

      return true;
    }

    public bool Exists(Guid id)
    {
      return _itemsById.ContainsKey(id);
    }

    public T GetById<T>(Guid id) where T : DomainObject
    {
      IDomainObject existingItem;
      return _itemsById.TryGetValue(id, out existingItem) ? existingItem as T : null;
    }

    protected void OnListChanged(object sender, ListChangedEventArgs e)
    {

      if (e.ListChangedType == ListChangedType.ItemAdded)
      {
        IList list = (IList)sender;
        IDomainObject addedItem = (IDomainObject) list[e.NewIndex];
        addedItem.Repository = this;
        _itemsById.Add(addedItem.Id, addedItem);
      }
     
      switch (e.ListChangedType)
      {
        case ListChangedType.ItemAdded:
        case ListChangedType.ItemDeleted:
        case ListChangedType.ItemMoved:
        case ListChangedType.ItemChanged:
          IsModified = true;
          OnPropertyChanged("IsModified");
          break;
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}