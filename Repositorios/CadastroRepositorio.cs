using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalWeb.Models;

namespace PontoDigitalWeb.Repositorios
{
    public class CadastroRepositorio 
    {
        private const string PATH = "DataBase/Cadastro.csv";

        private const string PATH2 = "DataBase/Administrador.csv";

        public void RegistrarUsuario(CadastroModel cadastro){

            if (File.Exists(PATH)){
                cadastro.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                cadastro.Id = 1;
            }
            StreamWriter sw = new StreamWriter (PATH, true);

             sw.WriteLine($"{cadastro.Id};{cadastro.Nome};{cadastro.DataNascimento};{cadastro.Telefone};{cadastro.RG};{cadastro.CPF};{cadastro.CEP};{cadastro.Endereco};{cadastro.Numero};{cadastro.Complemento};{cadastro.Bairro};{cadastro.Cidade};{cadastro.Estado};{cadastro.NomeEmpresa};{cadastro.CNPJ};{cadastro.Email};{cadastro.Senha};comum");
             sw.Close();
            
        }

        public List<CadastroModel> Listar(){
            List<CadastroModel> listaDeCadastrados = new List<CadastroModel>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                CadastroModel cadastro = new CadastroModel();
                cadastro.Id = int.Parse((dados[0]));
                cadastro.Nome = dados[1];
                cadastro.DataNascimento = DateTime.Parse(dados[2]);
                cadastro.Telefone = dados[3];
                cadastro.RG = dados[4];
                cadastro.CPF = dados[5];
                cadastro.CEP = dados[6];
                cadastro.Endereco = dados[7];
                cadastro.Numero = dados[8];
                cadastro.Complemento = dados[9];
                cadastro.Bairro = dados[10];
                cadastro.Cidade = dados[11];
                cadastro.Estado = dados[12];
                cadastro.NomeEmpresa = dados[13];
                cadastro.CNPJ = dados[14];
                cadastro.Email = dados[15];
                cadastro.Senha = dados[16];
                cadastro.Tipo = dados[17];

                listaDeCadastrados.Add(cadastro);
            }   
            return listaDeCadastrados;
        }

        public CadastroModel BuscarPorEmailESenha(string email, string senha){
            var listaDeCadastrados = Listar();
            foreach (var item in listaDeCadastrados)
            {
                if(item != null){
                    if (email.Equals (item.Email) && senha.Equals (item.Senha)) {
                            return item;
                    }
                }
            }
            return null;
        }

        public ComentariosModel RegistrarComentariosCSV(ComentariosModel comentarios){
            if (File.Exists(PATH2))
            {
                comentarios.Id = File.ReadAllLines(PATH2).Length + 1;
            }else{
                comentarios.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH2, true);
            sw.WriteLine($"{comentarios.Id}; {comentarios.Email}; {comentarios.Comentario};{comentarios.Status};{comentarios.DataComentario}");
            sw.Close();

            return comentarios;
        }

        public List<ComentariosModel> ListarComentario(){
            List<ComentariosModel> listaDeComentarios = new List<ComentariosModel> ();
            string[] linhas = File.ReadAllLines(PATH2);
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                ComentariosModel comentarios = new ComentariosModel();
                comentarios.Id = int.Parse(dados[0]);
                comentarios.Email = dados[1];
                comentarios.Comentario = dados[2];
                comentarios.Status = dados[3];

                listaDeComentarios.Add(comentarios); 
            }
            return listaDeComentarios;
        }
    }
}