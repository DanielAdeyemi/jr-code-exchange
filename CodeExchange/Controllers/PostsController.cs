// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;
// using CodeExchange.Models;

// namespace CodeExchange.Controllers
// {
//   [Authorize]
//   public class PostsController : Controller
//   {
//     private readonly CodeExchangeContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;
//     public AppUsersController(UserManager<ApplicationUser> userManager, CodeExchangeContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       return RedirectToAction("Home");
//     }


//   } 
// }