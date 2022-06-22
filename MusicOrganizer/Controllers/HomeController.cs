using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class HomeController : Controller
  {
    [Http("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}