using System;

namespace BoardGameLibrary.Data.Base
{
  public interface IDomainObject
  {
    Guid Id { get; }
    RepositoryBase Repository { get; set; }
  }
}