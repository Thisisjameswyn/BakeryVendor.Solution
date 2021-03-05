using System.Collections.Generic;

namespace BakeryOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    
    public string VendorName { get; set; }

    public int Id { get; }

    public List<Orders> Orders { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Orders>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Orders order)
    {
      Orders.Add(order);
    }
  }
}