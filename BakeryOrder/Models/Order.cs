using System.Collections.Generic;

namespace BakeryOrder.Models
{
  public class Order
  {
    public string OrderName { get; set; }

    public string OrderDescription { get; set; }

    public string OrderDate { get; set; }

    public string OrderPrice { get; set; }

    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderName, string orderDescription, string orderDate, string orderPrice)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderPrice = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}