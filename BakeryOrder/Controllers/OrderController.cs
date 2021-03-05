using Microsoft.AspNetCore.Mvc;
using BakeryOrder.Models;
using System.Collections.Generic;

namespace BakeryOrder.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/order")]
    public ActionResult Index()
    {
      List<Orders> allOrders = Orders.GetAll();
      return View(allOrders);
    }

    [HttpGet("/order/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/order")]
    public ActionResult Create(string cityName)
    {
      Orders myOrder = new Orders(cityName);
      return RedirectToAction("Index");
    }

    [HttpPost("/order/delete")]
    public ActionResult DeleteAll()
    {
      Orders.ClearAll();
      return View();
    }

    [HttpGet("/order/{id}")]
    public ActionResult Show(int id)
    {
      Orders foundOrders = Orders.Find(id);
      return View(foundOrders);
    }
  }
}