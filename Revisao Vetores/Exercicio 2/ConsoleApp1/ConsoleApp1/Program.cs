using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5] {45, 2, 67, 100, 1 };

            Console.WriteLine("O maior valor do vetor é: {0}", MaiorValor(vetor));
        }

        static int MaiorValor( int[] vetor)
        {
            int maiorvalor = vetor[0];

            for(int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] > maiorvalor)
                {
                    maiorvalor = vetor[i];
                }
            }

            return maiorvalor;
        }
    }
}
