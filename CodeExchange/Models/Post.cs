using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

    public string Age()
    {
    // 24hr+
    if(DateTime.Now.DayOfYear < this.CreationDate.DayOfYear)
    {
      return "Over 24 hrs";
    }
    else if(DateTime.Now.Hour == this.CreationDate.Hour) {
      return "New";
    }
    return Math.Abs(this.CreationDate.Hour - DateTime.Now.Hour).ToString() + "hrs";
    }
    // Generate preview up to 35 characters. If preview[35] != whitespace then keep building string up to 100
  public async Task<String> GeneratePreview() {
    if(this.Content.Length > 200 && this.Content.Length < 1000) {
    this.Preview = this.Content.Substring(0, 200);
    if (this.Preview[199] != ' '){
      for(int i = 200; i < 1000; i++) {
        if(this.Content[i] == ' ') {
          break;
        }
        this.Preview += this.Content[i];
      }
    }
    }
    else if(this.Content.Length < 200) {
    this.Preview = this.Content;
    return this.Preview;
    }
    return this.Preview;
  }
  }
}