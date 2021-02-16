using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa joao = new Pessoa();
            Pessoa maria = new Pessoa();

            Console.WriteLine("Qual é o seu nome?");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Qual é o seu peso?");
            pessoa1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual é a sua altura?");
            pessoa1.Altura = Convert.ToDouble(Console.ReadLine());

            joao.Nome = "João";
            joao.Altura = 1.90;
            joao.Peso = 98;

            maria.Nome = "Maria";
            maria.Altura = 1.50;
            maria.Peso = 55;

            joao.Altura = 1.78;
            maria.Peso = 55;

            ImprimirDados(pessoa1);
            ImprimirDados(joao);
            ImprimirDados(maria);
            ImprimirMedia(joao, maria);
            
        }

        static void ImprimirDados(Pessoa pessoa)
        {
            Console.WriteLine("\nDados recebidos do(a) {0}", pessoa.Nome);
            Console.WriteLine("Peso: {0}", pessoa.Peso);
            Console.WriteLine("Altura: {0:N2}", pessoa.Altura);
        }

        static void ImprimirMedia(Pessoa pessoa1, Pessoa pessoa2)
        {
            double mediaPeso, mediaAltura;

            mediaPeso = pessoa1.Peso+pessoa2.Peso;
            mediaAltura = pessoa1.Altura+pessoa2.Altura;

            Console.WriteLine("\nMedias entre {0} e {1}", pessoa1.Nome, pessoa2.Nome);
            Console.WriteLine("Peso: {0}", mediaPeso/2);
            Console.WriteLine("Altura: {0:N2}", mediaAltura/2);
        }
    }
}
