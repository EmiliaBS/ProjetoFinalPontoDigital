using System.Collections.Generic;
using PontoDigitalWeb.Models;

namespace PontoDigitalWeb.ViewModels
{
    public class ComentarioViewModel
    {
        public List<ComentariosModel> ListaDeComentarios {get; set;}
        public List<CadastroModel> Cadastrados {get; set;}    
    }
}