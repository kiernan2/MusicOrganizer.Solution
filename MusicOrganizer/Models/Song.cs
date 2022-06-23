using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Song
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Song> _instances = new List<Song>();
    public Song (string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static Song Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static List<Song> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}