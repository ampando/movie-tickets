using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MovieTickets.Models
{
  public class MovieTicketsContextFactory : IDesignTimeDbContextFactory<MovieTicketsContext>
  {

    MovieTicketsContext IDesignTimeDbContextFactory<MovieTicketsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<MovieTicketsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new MovieTicketsContext(builder.Options);
    }
  }
}