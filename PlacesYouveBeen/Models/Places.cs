using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Places
  {
    public string CityName { get; set; }

    public int StayTime { get; set; }
    public int Id { get; }
    private static List<Places> _instances = new List<Places> { };

    public Places(string cityName)
    {
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Places(int stayTime)
    {
      StayTime = stayTime;
      _instances.Add(this);
      Id = _instances.Count;
    }
    
    public Places(string cityName, int stayTime)
    {
      StayTime = stayTime;
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;
    }


    public static List<Places> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Places Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}