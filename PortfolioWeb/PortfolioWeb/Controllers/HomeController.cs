using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Name = "Nishidh Kanojiya",
            Intro = ".NET Developer ban raha hu vai !",
            Tagline = "Building innovative solutions with cutting-edge technologies"
        };
        return View(model);
    }
}