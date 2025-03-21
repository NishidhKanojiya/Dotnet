using Microsoft.AspNetCore.Mvc;

public class DownloadController : Controller
{
    private readonly IWebHostEnvironment _env;

    public DownloadController(IWebHostEnvironment env)
    {
        _env = env;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DownloadResume()
    {
        string filePath = Path.Combine(_env.WebRootPath, "downloads", "resume.pdf");

        if (!System.IO.File.Exists(filePath))
            return NotFound();

        return File(filePath, "application/pdf", "Nishidh_Resume.pdf");
    }
}