using System.Collections.Generic;

namespace MovieTickets.Models
{
  public class Movie
  {
    public Movie()
    {
      this.JoinEntities = new HashSet<MovieTheater>();
    }
    public int MovieId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<MovieTheater> JoinEntities { get;}
    
  }
}