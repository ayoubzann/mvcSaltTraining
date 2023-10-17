using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using mvcSaltTraining.Models;

namespace mvcSaltTraining.Controllers;

public class DevelopersController : Controller
{
    private Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }

    public IActionResult Index (){
        return View(_db.Developers);
    }

    public IActionResult Details (int id)
    {
       var developer = _db.Developers.Find(dev => dev.ID == id);
        return View(developer);
    }

    public IActionResult Create ()
    {
        return View();
    }

    [HttpPost]
public IActionResult Create(CreateNewDeveloperViewModel viewModel)
{
  var nextId = _db.Developers.Count;
  var developerToAdd = new Developer()
  {
    ID = nextId,
    Name = viewModel.Name,
    Email = viewModel.Email
  };
  _db.Developers.Add(developerToAdd);

  return RedirectToAction(nameof(Index));
  // return RedirectToAction(nameof(Details), new { Id = nextId });
}
}