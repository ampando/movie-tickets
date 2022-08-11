using System.Collections.Generic;

namespace MovieTickets.Models
{
  public class Theater
  {
    public Theater()
    {
      this.JoinEntities = new HashSet<MovieTheater>();
      // this.JoinSnacks = new HashSet<ConcessionsTheater>();
    }
    public int TheaterId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    // public int ConcessionsTheaterId { get; set; }
    // public virtual ConcessionsTheater ConcessionsTheater { get; set; }
    public virtual ICollection<MovieTheater> JoinEntities { get; }
    // public virtual ICollection<ConcessionsTheater> JoinSnacks { get; }
  }
}