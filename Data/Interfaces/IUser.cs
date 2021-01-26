using System;
using System.Collections.Generic;
using library_system.Domain.Models;

namespace library_system.Data.Interfaces
{
  public interface IUser
  {
    List<User> GetAll();
    User Create(User user);
    User GetById(Guid Id); 
    User Update(Guid id, User user);
    void Delete(Guid id);
  }
}
