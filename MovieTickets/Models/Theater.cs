using System.Collections.Generic;

namespace MovieTickets.Models
{
  public class Theater
  {
    public Theater()
    {
      this.JoinEntities = new HashSet<MovieTheater>();
    }
    public int TheaterId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public virtual ICollection<MovieTheater> JoinEntities { get; }
  }
}