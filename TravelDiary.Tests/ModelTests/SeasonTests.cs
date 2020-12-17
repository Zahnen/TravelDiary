using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
using System.Collections.Generic;
using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class SeasonTest : IDisposable
  {
    public void Dispose()
    {
      Season.ClearAll();
    }

    [TestMethod]
    public void SeasonConstructor_CreatesAnInstanceOfSeason_Season()
    {
      Season newSeason = new Season("test string");
      Assert.AreEqual(typeof(Season), newSeason.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string seasonName = "Test Season";
      Season newSeason = new Season(seasonName);
      string result = newSeason.SeasonName;
      Assert.AreEqual(seasonName, result);
    }
    [TestMethod]
    public void GetId_ReturnsSeasonId_Int()
    {
      string seasonName = "Test Season";
      Season newSeason = new Season(seasonName);
      int result = newSeason.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetSeasons_ReturnsAllSeasonObjects_SeasonsList()
    {
      string season01 = "Spring";
      string season02 = "Winter";
      Season newSeason1 = new Season(season01);
      Season newSeason2 = new Season(season02);
      List<Season> newSeasonsList = new List<Season> { newSeason1, newSeason2 };

      List<Season> result = Season.GetAll();

      CollectionAssert.AreEqual(newSeasonsList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectSeason_Season()
    {
      string season01 = "Spring";
      string season02 = "Winter";
      Season newSeason1 = new Season(season01);
      Season newSeason2 = new Season(season02);

      Season result = Season.Find(2);
      Assert.AreEqual(newSeason2, result);
    }
    [TestMethod]
    public void AddPlace_AssociatesPlaceWithSeason_PlaceList()
    {
    string season = "Summer";
    Season newSeason = new Season(season);
    string place = "Tokyo";
    Place newPlace = new Place(place);
    List<Place> newList = new List<Place> { newPlace };
    newSeason.AddPlace(newPlace);

    List<Place> result = newSeason.Places;
    CollectionAssert.AreEqual(newList, result);
    }
  }
}