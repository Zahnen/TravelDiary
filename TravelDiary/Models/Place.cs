using System;
using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    private static List<Place> _placeList = new List<Place> {};

    public Place(string cityName)
    {
      CityName = cityName;
      _placeList.Add(this);
    }

    public static List<Place> GetAll()
    {
      return _placeList;
    }

    public static void ClearAll()
    {
      _placeList.Clear();
    }
  }
}