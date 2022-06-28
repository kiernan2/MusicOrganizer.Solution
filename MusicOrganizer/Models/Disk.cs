using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Disk
  {
    public string Name { get; set; }
    public int Id { get; }
    private static List<Disk> _instances = new List<Disk>();
    public List<Song> Songs { get; set; }

    public Disk(string diskName)
    {
      Name = diskName;
      _instances.Add(this);
      Id = _instances.Count;
      Songs = new List<Song>();
    }
    public void AddSong(Song song)
    {
      Songs.Add(song);
    }
    public static Disk Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static List<Disk> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}