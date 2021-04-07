using System;
using System.Collections.Generic;

namespace CodeExchange.Models
{
  public class Post
  {
    public Post()
    {
      this.JoinEntities = new HashSet<AppUserForumPost>();
      this.CreationDate = DateTime.Now;
    }

    public int PostId { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Preview { get; set; }
    public DateTime CreationDate { get; set; }
    // public string IpAddress { get; set; }
    // public bool isComment { get; set; }
    public int CreatorId { get; set; }
    public bool IsVisible { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual List<Post> Comments { get; set; }
    public virtual ICollection<AppUserForumPost> JoinEntities { get; set; }

    public int Age(){
    // 24hr+
    if(DateTime.Now.DayOfYear < this.CreationDate.DayOfYear)
    {
      return 24;
    }

    return DateTime.Now.Hour - this.CreationDate.Hour;
  }
    // Generate preview up to 35 characters. If preview[35] != whitespace then keep building string up to 100
  public void GeneratePreview() {
    if(this.Content.Length > 35 && this.Content.Length < 100) {
    this.Preview = this.Content.Substring(0, 35);
    if (this.Preview[35] != ' '){
      for(int i = 35; i < 100; i++) {
        if(this.Content[i] == ' ') {
          break;
        }
        this.Preview += this.Content[i];
      }
    }
    }
    else if(this.Content.Length < 35) {
    this.Preview = this.Content;
    }
  }
  }
}