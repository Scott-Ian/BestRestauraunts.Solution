using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantsContext _db;
    public RestaurantsController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
      return View(model);
    }



  }
}