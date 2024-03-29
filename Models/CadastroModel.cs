using System;

namespace PontoDigitalWeb.Models
{
    public class CadastroModel
    {
        public int Id {get;set;}
        public string Nome {get; set;}

        public DateTime DataNascimento {get; set;}

        public string Telefone {get; set;}

        public string RG {get; set;}

        public string CPF {get; set;}

        public string CEP {get; set;}

        public string Endereco {get; set;}

        public string Numero {get; set;}

        public string Complemento {get; set;}

        public string Bairro {get; set;}

        public string Cidade {get; set;}

        public string Estado {get; set;}

        public string NomeEmpresa {get; set;}

        public string CNPJ {get; set;}

        public  string Email {get; set;}

        public string Senha {get; set;}
        public string Tipo {get;set;}
    }
}