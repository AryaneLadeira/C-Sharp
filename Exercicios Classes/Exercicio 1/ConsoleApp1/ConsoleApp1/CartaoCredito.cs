using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CartaoCredito
    {
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        
        }

        public string Numero 
        {
            get { return numero; } 
            set { numero = value; } 
        }

        public DateTime Validade 
        {
            get { return validade; } 
            set { validade = value; } 
        }

        public int CVV 
        {
            get { return cvv; } 
            set { cvv = value; }
        }

        private string nome;
        private string numero;
        private DateTime validade;
        private int cvv;
    }
}
