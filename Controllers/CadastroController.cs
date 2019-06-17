using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalWeb.Models;
using PontoDigitalWeb.Repositorios;

namespace PontoDigitalWeb.Controllers
{
    public class CadastroController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";

        private const string SESSION_TIPO = "_TIPO";

        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

       public IActionResult Index(){
           ViewData["NomeView"] = "Cadastro";
           return View();
       }
        [HttpPost]
        public IActionResult CadastroCliente (IFormCollection form)
        {
            CadastroModel cadastro = new CadastroModel();
            cadastro. Nome = form["nome"];
            cadastro.DataNascimento = DateTime.Parse(form["data"]);
            cadastro.Telefone = form["telefone"];
            cadastro.RG = form["rg"];
            cadastro.CPF = form["cpf"];
            cadastro.CEP = form["cep"];
            cadastro.Endereco = form["endereco"];
            cadastro.Numero = form["numero"];
            cadastro.Complemento = form["complemento"];
            cadastro.Bairro = form["bairro"];
            cadastro.Cidade = form["cidade"];
            cadastro.Estado = form["estado"];
            cadastro.NomeEmpresa = form["nomeEmpresa"];
            cadastro.CNPJ = form["cnpj"];
            cadastro.Email = form["email"];
            cadastro.Senha = form["senha"];

            cadastroRepositorio.RegistrarUsuario(cadastro);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Comentarios(){
            return View();
        }
        [HttpPost]

        public IActionResult Comentarios (IFormCollection form){
            var comentarioFormulario = form["comentario"];
            var email = HttpContext.Session.GetString(SESSION_EMAIL);

            ComentariosModel comentarios = new ComentariosModel();
            comentarios.Comentario = comentarioFormulario;
            cadastroRepositorio.RegistrarComentariosCSV(comentarios);

            return RedirectToAction("Index", "Home");


        }

    }
            
}