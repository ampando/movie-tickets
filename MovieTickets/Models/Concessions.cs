using System.Collections.Generic;

namespace MovieTickets.Models
{
  public class Concessions
  {
    public Concessions()
    {
      this.JoinSnacks = new HashSet<ConcessionsTheater>();
    }
    public int ConcessionsId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<ConcessionsTheater> JoinSnacks { get;}
    
  }
}