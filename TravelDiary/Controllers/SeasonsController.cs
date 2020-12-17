using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;

namespace TravelDiary.Controllers
{
  public class SeasonsController : Controller
  {
    [HttpGet("/seasons")]
    public ActionResult Index()
    {
      List<Season> allSeasons = Season.GetAll();
      return View(allSeasons);
    }

    [HttpGet("/seasons/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/seasons")]
    public ActionResult Create(string seasonName)
    {
      Season newSeason = new Season(seasonName);
      return RedirectToAction("Index");
    }
    [HttpGet("/seasons/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Season selectedSeason = Season.Find(id);
      List<Place> seasonPlaces = selectedSeason.Places;
      model.Add("season", selectedSeason);
      model.Add("places", seasonPlaces);
      return View(model);
    }
  }
}
