using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MovieTickets.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieTickets.Controllers
{
  public class TheaterController : Controller
{
private readonly MovieTicketsContext _db;

public TheaterController(MovieTicketsContext db)
{
  _db = db;
}

public ActionResult Index()
    {
      return View(_db.Theaters.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Theater theater, int MovieId)
    {
      _db.Theaters.Add(theater);
      _db.SaveChanges();
      if (MovieId != 0)
      {
          _db.MovieTheater.Add(new MovieTheater() { MovieId = MovieId, TheaterId = theater.TheaterId });
          _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
    
    public ActionResult Details(int id)
    {
      var thisTheater = _db.Theaters
          .Include(theater => theater.JoinEntities)
          .ThenInclude(join => join.Movie)
          .FirstOrDefault(theater => theater.TheaterId == id);
      return View(thisTheater);
    }
    public ActionResult AddMovie(int id)
    {
      var thisTheater = _db.Theaters.FirstOrDefault(theater => theater.TheaterId == id);
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "Name");
      return View(thisTheater);
    }

    [HttpPost]
    public ActionResult AddMovie(Theater theater, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieTheater.Add(new MovieTheater() { MovieId = MovieId, TheaterId = theater.TheaterId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
    public ActionResult Edit(int id)
    {
      var thisTheater = _db.Theaters.FirstOrDefault(theater => theater.TheaterId == id);
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "Name");
      return View(thisTheater);
    }

    [HttpPost]
    public ActionResult Edit(Theater theater, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieTheater.Add(new MovieTheater() { MovieId = MovieId, TheaterId = theater.TheaterId });
      }
      _db.Entry(theater).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    public ActionResult Delete(int id)
    {
      var thisTheater = _db.Theaters.FirstOrDefault(theater => theater.TheaterId == id);
      return View(thisTheater);
    }
    
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTheater = _db.Theaters.FirstOrDefault(theater => theater.TheaterId == id);
      _db.Theaters.Remove(thisTheater);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
        var joinEntry = _db.MovieTheater.FirstOrDefault(entry => entry.MovieTheaterId == joinId);
        _db.MovieTheater.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    } 
  }
}