using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieTickets.Models;

namespace MovieTickets
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json");
        Configuration = builder.Build();
    }

    public IConfiguration Configuration { get; set; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMVC();
        
        services.AddEntityFrameworkMySql()
            .AddDbContext<SalonContext>(options => options
            .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
        }
        
        public void Configure(IApplicationBuilder app)
        {
        app.UseDeveloperExceptionPage();
        app.UseRouting();
        app.UseStaticFiles();

        app.UseEndpoints(routes =>
        {
            routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
        });

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Oops, something has gone wrong!");
        }); 
      }
    }
}

