using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Qual é o seu peso?");
            pessoa1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual é a sua altura?");
            pessoa1.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDados recebidos:");
            Console.WriteLine("Peso: {0}", pessoa1.Peso);
            Console.WriteLine("Altura: {0}", pessoa1.Altura);
        }
    }
}
