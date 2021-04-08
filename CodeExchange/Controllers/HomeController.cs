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
  public class HomeController : Controller
  {
    private readonly CodeExchangeContext _db;
    private readonly UserManager<AppUser> _userManager;
    public HomeController(UserManager<AppUser> userManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    [AllowAnonymous]
    public async Task <ActionResult> Index()
    {
      Dictionary<string, AppUser> userList = new Dictionary<string, AppUser>();
      foreach(AppUser user in _db.AppUsers) {
        userList.Add(user.UserName, user);
      }

      ICollection<Forum> model = _db.Forums.ToList();
      // List<AppUser> AppUsersList = new List<AppUser>;
      foreach(Post post in _db.Posts) {
        // var thisUser = AppUsersList.FirstOrDefault(entry => entry.AppUserId == post.CreatorId);
        await post.GeneratePreview();
        // userList.Add(post.CreatorId, thisUser.Username);
         _db.Entry(post).State = EntityState.Modified;
      }
      _db.SaveChanges();
      ViewBag.userList = userList;
      ViewBag.postByDate = _db.Posts.ToList().OrderByDescending(e => e.CreationDate);
      ViewBag.postByPopularity = _db.Posts.Where(post => post.Title.Length > 0).ToList().OrderByDescending(e => e.Likes);
      // ViewBag.Usernames = userList;
      // (Implement on CSHTML) =
      // Scrolling list of most popular posts (stretch)
      // OR button at button to load next 10 most popular posts
      return View(model);
    }
  }
}