using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
namespace CodeExchange.Models
{
  public class CodeExchangeContext : IdentityDbContext<AppUser>
  {
    public virtual DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Forum> Forums { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<AppUserForumPost> AppUserForumPost { get; set; }

    public CodeExchangeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

            
            builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Role"); });

            builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });

            builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });

            builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });

            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });

            builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
      builder.Entity<Post>()
        .HasData(

          new Post { Creator = "Uncle Daniel", PostId = 1, Likes = 2, Dislikes = 0, Title= "Python Sucks", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", CreationDate = DateTime.Now.AddHours(5), CreatorId = 1, IsVisible = true },
          new Post { Creator = "Uncle Tien", PostId = 2, Likes = 100, Dislikes = 0, Title= "Swift Sucks", Content = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure", CreationDate = DateTime.Now, CreatorId = 2, IsVisible = true },
          new Post { Creator = "Uncle Mikey", PostId = 3, Likes = 3, Dislikes = 0, Title= "C# Sucks", Content = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain.", CreationDate = DateTime.Now, CreatorId = 3, IsVisible = true },
          new Post { Creator = "John", PostId = 4, Likes = 9, Dislikes = 0, Title= "Java Sucks", Content = "Here's a post", CreationDate = DateTime.Now, CreatorId = 4, IsVisible = true },
          new Post { Creator = "Lol2", PostId = 5, Likes = 0, Dislikes = 10, Title= "JavaScript Sucks", Content = "I would upload an image here if I had that functionality", CreationDate = DateTime.Now, CreatorId = 1, IsVisible = true }

      );
      builder.Entity<Forum>()
      .HasData(
        new Forum { ForumId = 1, Name = "Java Sukz"},
        new Forum { ForumId = 2, Name = "Python Rulez"},
        new Forum { ForumId = 3, Name = "Pyt Rules"},
        new Forum { ForumId = 4, Name = "Pyhon Rules"},
        new Forum { ForumId = 5, Name = "thon Rules"}
      );
    }
  }
}