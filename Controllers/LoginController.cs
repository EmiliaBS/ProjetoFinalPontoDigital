using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalWeb.Repositorios;

namespace PontoDigitalWeb.Controllers {
    public class LoginController : Controller {
        private const string SESSION_EMAIL = "_EMAIL";

        private const string SESSION_TIPO = "_TIPO";
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio ();
        public IActionResult Index ()
         {
            ViewData["NomeView"] = "Login";
            return View ();
        }

        public IActionResult Logar (IFormCollection form)
         {
            var email = form["email"];
            var senha = form["senha"];
            var cadastroRetornado = cadastroRepositorio.BuscarPorEmailESenha(email, senha);

            if(cadastroRetornado != null)
            {
                if(cadastroRetornado.Tipo == "admin")
                {
                    HttpContext.Session.SetString(SESSION_EMAIL, cadastroRetornado.Email);
                    HttpContext.Session.SetString(SESSION_TIPO, cadastroRetornado.Tipo);
                    return RedirectToAction("DashBoard","Admin");
                }else{
                    HttpContext.Session.SetString(SESSION_EMAIL, cadastroRetornado.Email);
                    HttpContext.Session.SetString(SESSION_TIPO, cadastroRetornado.Tipo);
                    return RedirectToAction("Comentarios","Cadastro");
                }
            }else{
                // uaurio não encontrado;
                
            }
        
            return RedirectToAction ("Index", "Home");
        }

        public IActionResult Logout () {
            HttpContext.Session.Remove (SESSION_EMAIL);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
    }
}