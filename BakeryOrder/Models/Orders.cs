using System.Collections.Generic;

namespace BakeryOrder.Models
{
  public class Orders
  {
    public string OrderName { get; set; }

    public string OrderDescription { get; set; }

    public string OrderDate { get; set; }

    public string OrderPrice { get; set; }

    public int Id { get; }
    private static List<Orders> _instances = new List<Orders> { };

    public Orders(string orderName, string orderDescription, string orderDate, string orderPrice)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderPrice = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Orders> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Orders Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}