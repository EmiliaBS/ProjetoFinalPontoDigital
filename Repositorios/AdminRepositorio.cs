using System.IO;
using System;
using PontoDigitalWeb.Models;
using System.Collections.Generic;
using PontoDigitalWeb.Controllers;

namespace PontoDigitalWeb.Repositorios
{
    public class AdminRepositorio
    {   
        private const string PATH = "Database/Admin.csv";

        public void ReagistarNoCSV(ComentariosModel comentarios){
            if (File.Exists(PATH))
            {
                comentarios.Id = File.ReadAllLines(PATH).Length +1;
            }else {
                comentarios.Id = 1;
            }
            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{comentarios.Id};{comentarios.Email};{comentarios.Comentario}; {comentarios.Status}; {comentarios.DataComentario}");
            sw.Close();
            
        }
        public List<AdminModel> Listar(){
            List<AdminModel> listaDeComentario = new List<AdminModel>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(string.IsNullOrEmpty(item))
                {
                continue;
                }
           
            string[] dados = item.Split(";");
            AdminModel admin = new AdminModel();
            admin.Id = int.Parse(dados[0]);
            admin.Nome = dados[1];
            admin.Email = dados[2];
            admin.Senha = dados[3];

            listaDeComentario.Add(admin);
        }
        return listaDeComentario;
    }

        
    }
    }
    
  
