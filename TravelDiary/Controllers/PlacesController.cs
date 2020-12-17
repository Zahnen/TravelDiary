using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;

namespace TravelDiary.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/places")]
    public ActionResult Create(string cityName)
    {
      Place myPlace = new Place(cityName);
      return RedirectToAction("Index");
    }
    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }
  }
}


    // [HttpPost("/items")]
    // public ActionResult Create(string description)
    // {
    //   Item myItem = new Item(description);
    //   return RedirectToAction("Index");
    // }

    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }

    // [HttpGet("/items/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Item foundItem = Item.Find(id);
    //   return View(foundItem);
    // }