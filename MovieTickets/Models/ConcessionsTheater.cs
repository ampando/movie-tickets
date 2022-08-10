namespace MovieTickets
{
  public class ConcessionsTheater
  {
    public int ConcessionsTheaterId { get; set; }
    public int TheaterId { get; set; }
    public int ConcessionsId { get; set; }
    public virtual Theater Theater { get; set; }
    public virtual Concessions Concessions { get; set; }
  }
}