using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pessoa
    {
        public double Peso
        {
            get { return peso; }

            set { peso = value; }

        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; } 
        }

        private double peso;
        private double altura;
    }
}
