using System;

namespace Questao2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho do vetor");
            int tamanhoVetor = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanhoVetor];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Insira o valor");
                int valor = int.Parse(Console.ReadLine());
                foreach (int v in vetor)
                    if (v != valor || v == null)
                        vetor[i] = valor;
                Console.WriteLine("Valor Invalido");
            }

            foreach (int i in vetor)
                Console.Write($"Vetor:{i} ");
        }
    }
}
