using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Disk
  {
    public string Description { get; set; }
    private static List<Disk> _instances = new List<Disk>();
    public Disk(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}