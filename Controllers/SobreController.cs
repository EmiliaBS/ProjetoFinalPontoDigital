using Microsoft.AspNetCore.Mvc;

namespace PontoDigitalWeb.Controllers
{
    public class SobreController : Controller{
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Sobre";
            return View();
        }
    }
}