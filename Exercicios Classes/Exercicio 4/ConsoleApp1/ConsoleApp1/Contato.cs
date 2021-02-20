using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Contato
    {
        public string Nome 
        {
            get { return nome; }
            set { nome = value; } 
        
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }

        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }

        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }

        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }

        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }

        }

        public string UF
        {
            get { return uf; }
            set { uf = value; }

        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }

        }

        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        private string nome;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string telefone;
        private string email;
    }
}
