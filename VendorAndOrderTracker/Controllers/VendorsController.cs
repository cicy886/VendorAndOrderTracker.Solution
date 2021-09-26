using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName)
        {
            Vendor newVendor = new Vendor(vendorName);
            return RedirectToAction("Index");
        }
    }
}
