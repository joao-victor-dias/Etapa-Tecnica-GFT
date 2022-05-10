using System;

namespace Questao2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do array: ");
            var tamanhoArray = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanhoArray];

            for (int i = 0; i < vetor.Length; i++)
            {
                bool existe = false;
                var valor = 0;

                do
                {
                    Console.Write("Digite um valor: ");
                    valor = int.Parse(Console.ReadLine());

                    existe = Array.Exists(vetor, x => x == valor);
                    if (existe)
                        Console.WriteLine("Valor existente no vetor!");
                } while (existe);

                vetor[i] = valor;
            }

            Array.Sort(vetor);
            foreach(var v in vetor)
                Console.WriteLine($"{v} ");            
        }
    }
}
