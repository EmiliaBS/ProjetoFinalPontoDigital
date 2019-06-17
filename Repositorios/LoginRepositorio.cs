using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalWeb.Models;

namespace PontoDigitalWeb.Repositorios
{
    public class LoginRepositorio
    {
        private static uint CONT = 0;
        
        private const string PATH = "DataBase/Cadastro.csv";
        private List<LoginModel> cadastro= new List<LoginModel>();

        public LoginRepositorio(){
            if (File.Exists(PATH))
            {

            }
        }    
    }     
}
