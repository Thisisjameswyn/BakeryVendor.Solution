using Microsoft.AspNetCore.Mvc;
using BakeryOrder.Models;
using System.Collections.Generic;

namespace BakeryOrder.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
      Vendor myVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendor/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }
  }
}