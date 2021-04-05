using Microsoft.AspNetCore.Mvc;

namespace CodeExchange.Controllers
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