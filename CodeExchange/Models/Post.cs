using System.Collections.Generic;

namespace CodeExchange.Models
{
  public class Post
  {
    public Post()
    {
      this.JoinEntities = new HashSet<AppUserForumPost>();
    }

    public int PostId { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreationDate { get; set; }
    // public string IpAddress { get; set; }
    // public bool isComment { get; set; }

    public List<Post> Comments { get; set; }
    public virtual ICollection<AppUserForumPost> JoinEntities { get; set; }
  }
}