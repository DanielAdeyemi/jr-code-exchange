using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using CodeExchange.Models;

namespace CodeExchange.Controllers
{
  [Authorize]
  public class AppUsersController : Controller
  {
    private readonly CodeExchangeContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public AppUsersController(UserManager<ApplicationUser> userManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return RedirectToAction("Index", "Home");
    }

    public ActionResult Edit(int id)
    {
      var thisUserApp = _db.AppUsers.FirstOrDefault( u => u.AppUserId == id);
      return View(thisUserApp);
    }
    [HttpPost]
    public ActionResult Edit(AppUser appUser)
    {
      _db.Entry(appUser).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisUserApp = _db.AppUsers.FirstOrDefault( u => u.AppUserId == id);
      return View(thisUserApp);
    }
    
    // Might need the signout function.
    [HttpPost]
    public ActionResult DeleteConfirmed(AppUser appUser)
    {
      appUser.IsVisible = false;
      _db.Entry(appUser).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}