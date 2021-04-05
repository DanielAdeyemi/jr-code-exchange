namespace CodeExchange.Models
{
  public class AppUserForumPost
  {
    public int AppUserForumPostId { get; set; }
    public int AppUserId { get; set; }
    public int ForumId { get; set; }
    public int Post { get; set; }

    public virtual AppUser AppUser { get; set; }
    public virtual Forum Forum { get; set; }
    public virtual Post Post { get; set; }
  }
}