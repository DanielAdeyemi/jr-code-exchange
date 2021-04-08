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
using System;

namespace CodeExchange.Controllers
{
  // [Authorize(Roles = "Uncle")]
  [Authorize]
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
      // ICollection<Forum> model = _db.Forums.ToList();
      return View(_db.Forums.ToList());
    }
    
    // [Authorize(Roles = "User")]
    [HttpGet]
    public ActionResult Details(int id)
    {
      
      // var thisForum = _db.Forums.FirstOrDefault(forum => forum.ForumId == id);
      // ViewBag.allPosts = _db.Posts.Where(post => post.ForumId == thisForum.ForumId).ToList();

      var thisForum = _db.Forums
        .Include(forum => forum.JoinEntities)
        .ThenInclude(join => join.Post)
        .FirstOrDefault(forum => forum.ForumId == id);
      
      // Dictionary<string, AppUser> userList = new Dictionary<string, AppUser>();
      // foreach(AppUser user in _db.AppUsers) {
      //   userList.Add(user.UserName, user);
      // }

      // ICollection<Forum> model = _db.Forums.ToList();
      // // List<AppUser> AppUsersList = new List<AppUser>;
      // foreach(Post post in _db.Posts) {
      //   // var thisUser = AppUsersList.FirstOrDefault(entry => entry.AppUserId == post.CreatorId);
      //   await post.GeneratePreview();
      //   // userList.Add(post.CreatorId, thisUser.Username);
      //    _db.Entry(post).State = EntityState.Modified;
      // }
      // _db.SaveChanges();
      // ViewBag.userList = userList;
      // ViewBag.postByDate = _db.Posts.ToList().OrderByDescending(e => e.CreationDate);
      // ViewBag.postByPopularity = _db.Posts.ToList( ).OrderByDescending(e => e.Likes);

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

    [HttpPost]
    public ActionResult LikedPost(Post likedPost)
    {
      var thisPost = _db.Posts.FirstOrDefault(post => post.PostId == likedPost.PostId);
      
      Console.WriteLine("POSTID FROM FIRSTORDEFAULT: " + thisPost.PostId);
      Console.WriteLine("USERNAME: " + likedPost.Creator);
      Console.WriteLine("POSTID: " + likedPost.PostId);
      thisPost.Likes++;
      Console.WriteLine(thisPost.Title);
      _db.Entry(thisPost).State = EntityState.Modified;
      _db.SaveChanges();
      return  RedirectToAction("Details", "Forums", new { id = likedPost.CreatorId });
    }

    [HttpPost]
    public ActionResult DisLikePost(Post disLikePost)
    {
      var thisPost = _db.Posts.FirstOrDefault(post => post.PostId == disLikePost.PostId);
      thisPost.Dislikes++;
      _db.Entry(thisPost).State = EntityState.Modified;
      _db.SaveChanges();
      return  RedirectToAction("Details", "Forums", new { id = disLikePost.CreatorId });
    }
  }
}
