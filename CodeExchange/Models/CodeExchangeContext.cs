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
      builder.Entity<Forum>()
      .HasData(
        new Forum { ForumId = 1, Name = "Strata"},
        new Forum { ForumId = 2, Name = "C#"},
        new Forum { ForumId = 3, Name = "Python"},
        new Forum { ForumId = 4, Name = "Ruby"},
        new Forum { ForumId = 5, Name = "Java"},
        new Forum { ForumId = 6, Name = "C#"},
        new Forum { ForumId = 7, Name = "C++"},
        new Forum { ForumId = 8, Name = "CSS"},
        new Forum { ForumId = 10, Name = "C"},
        new Forum { ForumId = 11, Name = "Assembly"},
        new Forum { ForumId = 12, Name = "COBOL"},
        new Forum { ForumId = 13, Name = "F#"},
        new Forum { ForumId = 14, Name = "Go"},
        new Forum { ForumId = 15, Name = "MySQL"},
        new Forum { ForumId = 16, Name = "Objective-C"},
        new Forum { ForumId = 17, Name = "Swift"},
        new Forum { ForumId = 18, Name = "SQL"},
        new Forum { ForumId = 19, Name = "SQL Lite"},
        new Forum { ForumId = 20, Name = "Visual Basic"},
        new Forum { ForumId = 21, Name = "XML"},
        new Forum { ForumId = 22, Name = "HTML"},
        new Forum { ForumId = 23, Name = "BASH"},
        new Forum { ForumId = 24, Name = "PowerShell"},
        new Forum { ForumId = 25, Name = "JavaScript"},
        new Forum { ForumId = 26, Name = "Jobhunting"},
        new Forum { ForumId = 27, Name = "Show Case"}
      );
    }
  }
}