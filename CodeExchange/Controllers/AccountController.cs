using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using CodeExchange.ViewModels;
using CodeExchange.Models;
using System.Linq;
using System;

namespace CodeExchange.Models
{
  public class AccountController : Controller
  {
    private readonly CodeExchangeContext _db;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AccountController (UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      ViewBag.count = 0;

      var user = new AppUser { UserName = model.Username, Email = model.Email, CreationDate = DateTime.Now};
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);

      var userList = _db.AppUsers.ToList();
      var descendingList = userList.OrderByDescending(u => u.AppUserId).ToList();
      int lastUserId = descendingList[0].AppUserId;

      if(result.Succeeded)
      {
        ViewBag.count = 0;

        user.AppUserId = lastUserId + 1;
        Console.WriteLine("ID GRABBED: " + lastUserId);
        Console.WriteLine("ACCOUNT ID: " + user.Id);
        Console.WriteLine("ACCOUNT APPUSERID: " + user.AppUserId);
        Console.WriteLine("ACCOUNT USERNAME: " + user.UserName);
        _db.SaveChanges();
        return RedirectToAction("Login");
      }
      else
      {
        ViewBag.count++;
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, isPersistent: true, lockoutOnFailure: false);

      if(result.Succeeded)
      {
        Console.WriteLine("THIS USER's ID: " + model.Username);
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View();
      }
    }

    // [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");
    }
  }
}