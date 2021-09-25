using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Items { get; set; }
  }
}