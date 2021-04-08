using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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


        // public string IpAddress { get; set; }
        public virtual ApplicationUser User { get; set; }  
        public virtual ICollection<AppUserForumPost> JoinEntities { get; set; }
      
        public async Task<AppUser> LikePost(Post post, CodeExchangeContext UsersDb)
        {
            if (this.Likes.Contains(post) == false && this.Dislikes.Contains(post) == false)
            {
                this.Likes.Add(post);
                post.Likes++;
                //Target user and add rep
                var targetUser = UsersDb.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
                if (targetUser == null)
                {
                    return targetUser;
                }
                else
                {
                    targetUser.Rep++;
                    await UsersDb.SaveChangesAsync();
                    return targetUser;
                }
            }
            return null;
        }
      
        public async Task<AppUser> DislikePost(Post post, CodeExchangeContext UsersDb)
        {
            if (this.Likes.Contains(post) == false && this.Dislikes.Contains(post) == false)
            {
                this.Dislikes.Add(post);
                post.Dislikes++;
                //Target user and decrement rep
                var targetUser = UsersDb.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
                if (targetUser == null)
                {
                    return null;
                }
                else
                {
                    targetUser.Rep--;
                    await UsersDb.SaveChangesAsync();
                    return targetUser;
                }
            }
            return null;
        }
      
        public async Task<AppUser> RemoveLike(Post post, CodeExchangeContext UsersDb)
        {
            if (this.Likes.Contains(post) == true)
            {
                this.Likes.Remove(post);
                post.Likes--;
                //Target user and decrement rep
                var targetUser = UsersDb.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
                if (targetUser == null)
                {
                    return null;
                }
                else
                {
                    targetUser.Rep--;
                    await UsersDb.SaveChangesAsync();
                    return targetUser;
                }

            }
            else if (this.Dislikes.Contains(post) == true)
            {
                this.Dislikes.Remove(post);
                post.Dislikes--;
                //Target user and decrement rep
                var targetUser = UsersDb.AppUsers.FirstOrDefault(Entry => Entry.AppUserId == post.CreatorId);
                if (targetUser == null)
                {
                    return null;
                }
                else
                {
                    targetUser.Rep--;
                    await UsersDb.SaveChangesAsync();
                    return targetUser;
                }
            }
            return null;
        }
        
    }
}