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
    public string Snacks { get; set; }
    public string Booze { get; set;}
    public string Candy { get; set; }
    public virtual ICollection<ConcessionsTheater> JoinSnacks { get;}
    
  }
}