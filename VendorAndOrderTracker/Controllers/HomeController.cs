using Microsoft.AspNetCore.Mvc;

namespace VenderAndOrderTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}