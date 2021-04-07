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
  [Authorize(Roles = "Uncle")]
  public class ForumsController : Controller
  {
    private readonly CodeExchangeContext _db;
    private readonly UserManager<AppUser> _userManager;
    public ForumsController(UserManager<AppUser> userManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      ICollection<Forum> model = _db.Forums.ToList();
      return View(model);
    }
    
    [Authorize(Roles = "User")]
    [HttpGet]
    public ActionResult Details(int id)
    {
      var thisForum = _db.Forums
        .Include(forum => forum.JoinEntities)
        .ThenInclude(join => join.Post)
        .FirstOrDefault(forum => forum.ForumId == id);
      return View(thisForum);
    }

    [HttpGet]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Forum forum) {
      _db.Forums.Add(forum);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
      var thisForum = _db.Forums.FirstOrDefault(forum => forum.ForumId == id);
      return View(thisForum);
    }

    [HttpPost]
    public ActionResult Edit(Forum forum)
    {
      _db.Entry(forum).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Archive(int id)
    {
      var thisForum = _db.Forums.FirstOrDefault(forum => forum.ForumId == id);
      return View(thisForum);
    }

    [HttpPost]
    public ActionResult Archive(Forum forum)
    {
      forum.IsVisible = false;
      _db.Entry(forum).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
