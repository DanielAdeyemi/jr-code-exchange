using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CodeExchange.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            this.JoinEntities = new HashSet<AppUserForumPost>();
            this.Role = "User";
            this.IsVisible = true;
        }

        public int AppUserId { get; set; }
        // public string DisplayName { get; set; }
        // public string Password { get; set; }
        // public string Email { get; set; }
        public string Role { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public int Rep { get; set; }
        public bool IsVisible { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastActive { get; set; }
        public virtual List<AppUser> UserFollowers { get; set; } // Each user's Id
        public virtual List<AppUser> UserFollowing { get; set; }
        public virtual List<Post> Likes { get; set; } //List of user likes & dislikes -CB
        public virtual List<Post> Dislikes { get; set; }


        // // public string IpAddress { get; set; }
        // public virtual ApplicationUser User { get; set; }  
        public virtual ICollection<AppUserForumPost> JoinEntities { get; set; }
      
 
    }
}