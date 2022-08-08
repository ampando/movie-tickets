using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MovieTickets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MovieTickets.Controllers
{
  public class CoursesController : Controller
  {
    private readonly MovieTicketsContext _db;

    public CoursesController(MovieTicketsContext db)
    {
      _db = db;
    }

  }
}