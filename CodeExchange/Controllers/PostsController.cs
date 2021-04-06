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
  public class PostsController : Controller
  {
    private readonly CodeExchangeContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public PostsController(UserManager<ApplicationUser> userManager, CodeExchangeContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index(int forumId)
    {
      // Forum thisForum = _db.Forums.FirstOrDefault(entry => entry.ForumId == id);
      var thisForum = await _db.Forums.FirstOrDefaultAsync(entry => entry.ForumId == forumId);
      List<Post> posts = new List<Post>();
      foreach(AppUserForumPost post in thisForum.JoinEntities)
      {
        if(post.ForumId == thisForum.ForumId)
        {
          var newPost = await _db.Posts.FirstOrDefaultAsync(entry => entry.PostId == post.PostId);
          posts.Add(newPost);
        }
      }
      return View(posts);
    }
    
    [HttpGet]
    public ActionResult Details(int id)
    {
      var thisPost = _db.Posts
        .Include(post => post.JoinEntities)
        .ThenInclude(join => join.Forum)
        .FirstOrDefault(post => post.PostId == id);
      return View(thisPost);
    }

    [HttpGet]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Post post) {
      _db.Posts.Add(post);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(post => post.PostId == id);
      return View(thisPost);
    }

    [HttpPost]
    public ActionResult Edit(Post post)
    {
      _db.Entry(post).State = EntityState.Modified;
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
