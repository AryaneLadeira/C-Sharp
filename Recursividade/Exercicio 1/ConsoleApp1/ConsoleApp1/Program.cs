/*Faça um programa que receba um inteiro por parâmetro e imprima todos os números pares entre 0 e o número passado por parâmetro.
 Considere que serão passados somente inteiros positivos por parâmetro. */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir(7);
        }

        static void Imprimir(int valor)
        {
            if(valor > 0)
            Imprimir(valor - 1);

            if (valor % 2 == 0)
                Console.WriteLine(valor);
        }

    }
}
