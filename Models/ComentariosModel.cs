using System;

namespace PontoDigitalWeb.Models
{
    public class ComentariosModel
    {
        public int Id {get;set;}

        public string Email {get;set;}

        public string Comentario {get;set;}

        public string Status {get;set;}

        public DateTime DataComentario {get; set;}
    }
}