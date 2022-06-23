using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class DiskController : Controller
  {

    [HttpPost("/disk")]
    public ActionResult Index()
    {
      List<Disk> allDisk = Disk.GetAll();
      return View(allDisk);
    }
  }
}