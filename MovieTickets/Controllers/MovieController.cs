using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MovieTickets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieTickets.Controllers
{
  public class MoviesController : Controller
  {
    private readonly MovieTicketsContext _db;

    public MoviesController(MovieTicketsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Movie> model = _db.Movies.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Movie movie)
    {
      _db.Movies.Add(movie);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMovie = _db.Movies
      .Include(movie => movie.JoinEntities)
      .ThenInclude(join => join.Theater)
      .FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    public ActionResult Edit(int id)
    {
      var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }
    [HttpPost]
    public ActionResult Edit(Movie movie)
    {
      _db.Entry(movie).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisMovie = _db.Movies.FirstOrDefault(Movie => Movie.MovieId == id);
      return View(thisMovie);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMovie = _db.Movies.FirstOrDefault(Movie => Movie.MovieId == id);
      _db.Movies.Remove(thisMovie);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }    
  }
}