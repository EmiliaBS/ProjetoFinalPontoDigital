using Microsoft.AspNetCore.Mvc;

namespace PontoDigitalWeb.Controllers
{
    public class PlanosController : Controller{
    
       public IActionResult Index()
        {
            ViewData["NomeView"] = "Planos";
            return View();
        } 
    }
}
