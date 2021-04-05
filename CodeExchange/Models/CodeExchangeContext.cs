using Microsoft.EntityFrameWorkCore;

namespace CodeExchange.Models
{
  public class CodeExchangeContext : DbContext
  {
    public virtual DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Forum> Forums { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<AppUserForumPost> AppUserForumPost { get; set; }

    public CodeExchangeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuild optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}