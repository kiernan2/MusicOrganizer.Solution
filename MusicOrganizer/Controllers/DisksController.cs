using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class DisksController : Controller
  {

    [HttpGet("/disks")]
    public ActionResult Index()
    {
      List<Disk> allDisk = Disk.GetAll();
      return View(allDisk);
    }

    [HttpGet("/disks/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/disks/{Id}")]
    public ActionResult Show(int id)
    {
      Disk selectedDisk = Disk.Find(id);
      return View(selectedDisk);
    }

    [HttpPost("disks")]
    public ActionResult Create(string diskName, string artistName)
    {
      Disk newDisk = new Disk(diskName, artistName);
      return RedirectToAction("Index");
    }

    [HttpGet("/disks/search")]
    public ActionResult Search(string searchArtist)
    {
      return View(searchArtist);
    }

    [HttpPost("/disks/{diskId}/songs")]
    public ActionResult Create(int diskId, string songDescription)
    {
      Disk foundDisk = Disk.Find(diskId);
      Song newSong = new Song(songDescription);
      foundDisk.AddSong(newSong);
      return View("Show", foundDisk);
    }
  }
}