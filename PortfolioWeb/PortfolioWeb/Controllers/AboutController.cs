using Microsoft.AspNetCore.Mvc;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        var model = new AboutViewModel
        {
            Background = "Pursuing Msc Computer Science at Fergusson College!",
            Experience = "Specializing in ASP.NET Core and cloud technologies",
            Goals = "To create impactful enterprise solutions"
        };
        return View(model);
    }
}