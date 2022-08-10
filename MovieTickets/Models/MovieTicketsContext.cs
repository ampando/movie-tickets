using Microsoft.EntityFrameworkCore;

namespace MovieTickets.Models
{
  public class MovieTicketsContext : DbContext
  {
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Theater> Theaters { get; set; }
    public DbSet<Concessions> Concessions { get; set; }
    public DbSet<MovieTheater> MovieTheater { get; set; }
    public DbSet<ConcessionsTheater> ConcessionsTheater { get; set; }

    public MovieTicketsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}