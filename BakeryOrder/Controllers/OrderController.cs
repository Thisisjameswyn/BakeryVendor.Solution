using Microsoft.AspNetCore.Mvc;
using BakeryOrder.Models;
using System.Collections.Generic;

namespace BakeryOrder.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Orders> allOrders = Orders.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
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
  }
}