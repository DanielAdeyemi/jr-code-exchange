using System;
using System.Collections.Generic;

namespace CodeExchange.Models
{
  public class AppUser
  {
    public AppUser()
    {
      this.JoinEntities = new HashSet<AppUserForumPost>();
    }

    public int AppUserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int Rep { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastActive { get; set; }
    public HashSet<int> UserFollowers { get; set; } // Each user's Id
    public HashSet<int> UserFollowing { get; set; }

    public string IpAddress { get; set; }

    public virtual ICollection<AppUserForumPost> JoinEntities { get; set; }
  }
}