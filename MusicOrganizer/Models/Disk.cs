using System.Collections.Generic;
using System;

namespace MusicOrganizer.Models
{
  public class Disk
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Artist { get; set; }
    private static List<Disk> _instances = new List<Disk>();
    public List<Song> Songs { get; set; }

    public Disk(string diskName, string artistName)
    {
      Name = diskName;
      Artist = artistName;
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
    public static List<Disk> FindArtist(string searchArtist)
    {
      List<Disk> results = _instances.FindAll(d => d.Artist == searchArtist);
      return results;
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