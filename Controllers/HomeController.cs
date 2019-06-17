using Microsoft.AspNetCore.Mvc;
using PontoDigitalWeb.Repositorios;

namespace PontoDigitalWeb.Controllers {
    public class HomeController : Controller {

        CadastroRepositorio CadastrRepositorio = new CadastroRepositorio();
        public IActionResult Index()
        {
         ViewData["NomeView"] = "Home";
        return View();    
        }
    }
}
