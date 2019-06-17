using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalWeb.Models;
using PontoDigitalWeb.Repositorios;
using PontoDigitalWeb.ViewModels;

namespace PontoDigitalWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult DashBoard(){
            CadastroRepositorio coments = new CadastroRepositorio();
            ComentarioViewModel comentarios = new ComentarioViewModel();
            var listaRecuperada = coments.ListarComentario();
            comentarios.ListaDeComentarios = listaRecuperada;
            return View(comentarios);
        }
        
        public IActionResult Listar(){

            return View();
        }

    }

    }

