using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
using System;
using System.Collections.Generic;


namespace TravelDiary.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      string newCity = "Seoul";
      Place newPlace = new Place(newCity);
      Assert.AreEqual(newCity, newPlace.CityName);
    }
    [TestMethod]
    public void GetAll_ReturnListOfPlaceObjectsIntantiated_PlaceList()
    {
      string newCity = "Seoul";
      Place newPlace = new Place(newCity);
      List<Place> placeList = new List<Place> {newPlace};
      List<Place> getResult = Place.GetAll();
      CollectionAssert.AreEqual(placeList, getResult);
    }

    [TestMethod]
    public void GetId_PlaceInstantiatedWithId
  }
}