namespace MovieTickets.Models
{
  public class MovieTheater
  {       
    public int MovieTheaterId { get; set; }
    public int TheaterId { get; set; }
    public int MovieId { get; set; }
    public virtual Theater Theater { get; set; }
    public virtual Movie Movie { get; set; }
  }
}