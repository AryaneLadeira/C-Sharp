using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[5] {1, 0, 7, -58, -5};

            NegativoParaPositivo(vetor);
            LerVetor(vetor);
            
        }

        static void NegativoParaPositivo(double[] vetor)
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                    vetor[i] *= -1;
            }
        }

        static void LerVetor(double[] vetor)
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Valor {i}: {vetor[i]}");
            }
        }
    }
}
