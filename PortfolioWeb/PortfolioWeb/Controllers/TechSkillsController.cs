using Microsoft.AspNetCore.Mvc;

public class TechSkillsController : Controller
{
    public IActionResult Index()
    {
        var model = new TechSkillsViewModel
        {
            Skills = new Dictionary<string, List<string>>
            {
                { "Languages", new List<string> { "C#", "JavaScript", "SQL", "Python" } },
                { "Frameworks", new List<string> { "ASP.NET Core", "Entity Framework", "React" } },
                { "Tools", new List<string> { "Visual Studio", "VsCode", "Git", "Docker" } }
            }
        };
        return View(model);
    }
}