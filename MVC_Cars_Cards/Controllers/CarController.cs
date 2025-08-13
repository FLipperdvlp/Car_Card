using Microsoft.AspNetCore.Mvc;

namespace MVC_Cars_Cards.Controllers;

public class CarController(DataBase.DataBase dataBase) : Controller
{
    public IActionResult Index()
    {
        return View(dataBase.Cars);
    }
}