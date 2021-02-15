using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito cartao1 = new CartaoCredito();
            CartaoCredito cartao2 = new CartaoCredito();

            cartao1.Nome = "Anna Maria da Silva";
            cartao1.Numero = "1234 1234 1234 1234";
            cartao1.Validade = new DateTime(2022, 02, 23);
            cartao1.CVV = 123;

            cartao2.Nome = "Luis Carlos Roberto";
            cartao2.Numero = "1111 2222 3333 4444";
            cartao2.Validade = new DateTime(2023, 05, 03);
            cartao2.CVV = 777;

            LerCartao(cartao2);
        }

        static void LerCartao(CartaoCredito cartao)
        {
            Console.WriteLine("\nDados do cartao");
            Console.WriteLine("{0}", cartao.Nome);
            Console.WriteLine("{0}", cartao.Numero);
            Console.WriteLine("Validade: {0}/{1} CVV {2}", cartao.Validade.Month, cartao.Validade.Year, cartao.CVV);
        }
    }
}
