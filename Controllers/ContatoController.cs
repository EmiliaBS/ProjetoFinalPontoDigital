using Microsoft.AspNetCore.Mvc;

namespace PontoDigitalWeb.Controllers
{
    public class ContatoController : Controller
    {
    
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Contato";
            return View();
        }
    
        
    }
}