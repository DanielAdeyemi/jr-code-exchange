using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeExchange.Models
{

  public class AppUtility
  {
    private readonly CodeExchangeContext _db;

    public AppUtility(CodeExchangeContext db)
    {
      _db = db;
    }

    //pass in User.Identity.Name
    public Post LikePost(Post post, string username)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
      System.Console.WriteLine("i made it");
      var currentUser = _db.AppUsers.FirstOrDefault(Entry => Entry.UserName == username);
      var thisPost = _db.Posts.FirstOrDefault(post => post.PostId == post.PostId);
      // Console.WriteLine("THISPOST LIKES: " + thisPost.Likes);
      // Console.WriteLine("CURRENTUSER LIKES = " + currentUser.Likes);

      if (currentUser.Likes.Contains(thisPost) == false && currentUser.Dislikes.Contains(thisPost) == false)
      {
        currentUser.Likes.Add(thisPost);
        thisPost.Likes++;
        _db.Entry(thisPost).State = EntityState.Modified;
        _db.SaveChanges();
        // Console.WriteLine("NEW UPDATED POST LIKES: " + thisPost.Likes);
        // Console.WriteLine("NEW UPDATED CURRENTUSER LIKES = " + currentUser.Likes);


        //Target user and add rep
        var targetUser = _db.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == thisPost.CreatorId);
        if (targetUser == null)
        {
          return thisPost;
        }
        else
        {
          targetUser.Rep++;
          _db.Entry(targetUser).State = EntityState.Modified;
          _db.SaveChanges();
          return thisPost;
        }
      }
      else
      {
        Console.WriteLine("YOU ALREADY LIKED THIS POST!");
        return thisPost;
      }
    }
    public void DislikePost(Post post, string username)
    {
      var currentUser = _db.AppUsers.FirstOrDefault(Entry => Entry.UserName == username);

      if (currentUser.Likes.Contains(post) == false && currentUser.Dislikes.Contains(post) == false)
      {
        currentUser.Dislikes.Add(post);
        post.Likes++;
        //Target user and add rep
        var targetUser = _db.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
        if (targetUser == null)
        {
          return;
        }
        else
        {
          targetUser.Rep++;
          _db.Entry(targetUser).State = EntityState.Modified;
          _db.SaveChanges();
          return;
        }
      }
      else
      {
        RemoveLike(post, username);
      }
    }
    public void RemoveLike(Post post, string username)
    {
      var currentUser = _db.AppUsers.FirstOrDefault(Entry => Entry.UserName == username);

      if (currentUser.Likes.Contains(post) == true)
      {
        currentUser.Likes.Remove(post);
        post.Likes--;
        //Target user and decrement rep
        var targetUser = _db.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
        if (targetUser == null)
        {
          return;
        }
        else
        {
          targetUser.Rep--;
          _db.Entry(targetUser).State = EntityState.Modified;
          _db.SaveChanges();
          return;
        }
      }
      else if (currentUser.Dislikes.Contains(post) == true)
      {
        currentUser.Dislikes.Remove(post);
        post.Dislikes--;
        //Target user and decrement rep
        var targetUser = _db.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
        if (targetUser == null)
        {
          return;
        }
        else
        {
          targetUser.Rep--;
          _db.Entry(targetUser).State = EntityState.Modified;
          _db.SaveChanges();
          return;
        }
      }
      return;
    }

  }
}