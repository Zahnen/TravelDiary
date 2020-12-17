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

  }
}