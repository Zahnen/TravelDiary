using System;
using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }
    private static List<Place> _placeList = new List<Place> {};

    public Place(string cityName)
    {
      CityName = cityName;
      _placeList.Add(this);
      Id = _placeList.Count;
    }

    public static List<Place> GetAll()
    {
      return _placeList;
    }

    public static void ClearAll()
    {
      _placeList.Clear();
    }

    public static Place Find(int searchId)
    {
      return _placeList[searchId-1];
    }
  }
}