using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devdayapi.Model
{
  public class Customer
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
  }
}