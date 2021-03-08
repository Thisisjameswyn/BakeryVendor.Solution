using Microsoft.AspNetCore.Mvc;
using BakeryOrder.Models;
using System.Collections.Generic;

namespace BakeryOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders")]
    public ActionResult Create(string cityName)
    {
      Orders myOrder = new Orders(cityName);
      return RedirectToAction("Index");
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Orders.ClearAll();
      return View();
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Orders foundOrders = Orders.Find(id);
      return View(foundOrders);
    }

    [HttpGet("/vendor/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Orders order = Orders.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}