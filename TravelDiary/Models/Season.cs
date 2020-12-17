using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Season
  {
    private static List<Season> _seasonsList = new List<Season> {};
    public string SeasonName { get; set; }
    public int Id { get; }
    public List<Place> Places { get; set; }
  
    public Season(string seasonName)
    {
      SeasonName = seasonName;
      _seasonsList.Add(this);
      Id = _seasonsList.Count;
      Places = new List<Place>{};
    }

    public static List<Season> GetAll()
    {
      return _seasonsList;
    }

    public static Season Find(int Id)
    {
      return _seasonsList[Id-1];
    }

    public static void ClearAll()
    {
      _seasonsList.Clear();
    }

    public void AddPlace(Place place)
    {
      Places.Add(place);
    }
  }
}