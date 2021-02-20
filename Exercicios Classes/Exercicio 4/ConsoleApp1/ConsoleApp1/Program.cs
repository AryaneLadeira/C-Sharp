using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite os dados do novo contato");
            Console.WriteLine("\nNome: ");
            contato.Nome = Console.ReadLine();

            Console.WriteLine("Endereço");
            Console.WriteLine("   Logradouro: ");
            contato.Logradouro = Console.ReadLine();

            Console.WriteLine("   Número: ");
            contato.Numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   Complemento: ");
            contato.Complemento = Console.ReadLine();

            Console.WriteLine("   Bairro: ");
            contato.Bairro = Console.ReadLine();

            Console.WriteLine("   Cidade: ");
            contato.Cidade = Console.ReadLine();

            Console.WriteLine("   UF: ");
            contato.UF = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            contato.Telefone = Console.ReadLine();

            Console.WriteLine("E-mail: ");
            contato.Email = Console.ReadLine();

            Console.WriteLine("---------------------------");

            Console.WriteLine("\n{0}", contato.Nome);
            Console.WriteLine("Rua {0}, {1}, {2}, {3}, {4} ", contato.Logradouro, contato.Complemento, contato.Bairro, contato.Cidade, contato.UF);

            Console.WriteLine("Telefone: {0}", contato.Telefone);
            Console.WriteLine("E-mail: {0}", contato.Email);
        }
    }
}
