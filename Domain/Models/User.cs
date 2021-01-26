using System;

namespace library_system.Domain.Models
{
  public class User
  {
    public Guid Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
  }
}
