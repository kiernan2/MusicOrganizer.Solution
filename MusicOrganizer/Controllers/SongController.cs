using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class SongsController : Controller
  {
    [HttpPost("/songs/delete")]
    public ActionResult DeleteAll()
    {
      Song.ClearAll();
      return View();
    }

    [HttpGet("/disks/{diskId}/songs/new")]
    public ActionResult New(int diskId)
    {
      Disk disk = Disk.Find(diskId);
      return View(disk);
    }

    [HttpGet("/disks/{diskId}/songs/{songId}")]
    public ActionResult Show(int diskId, int songId)
    {
      Song song = Song.Find(songId);
      Disk disk = Disk.Find(diskId);
      Dictionary<string, object> myDictionary = new Dictionary<string, object>();
      myDictionary.Add("song", song);
      myDictionary.Add("disk", disk);
      return View(myDictionary);
    }
  }
}