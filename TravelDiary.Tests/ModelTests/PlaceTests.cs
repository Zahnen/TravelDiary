using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class Place // : IDisposable
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      string cityName = "paris";
      Place newPlace = new Place(cityName);
      Assert.AreEqual(cityName, newPlace.CityName);
    }
  }
}