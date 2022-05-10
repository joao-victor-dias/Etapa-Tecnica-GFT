using System;

namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Aplicação de desconto ou acréscimo");
            Console.WriteLine("");

            Console.Write("Digite a descrição do produto: ");
            var descricao = Console.ReadLine();

            Console.Write("Digite o valor real do produto: ");
            var valorReal = double.Parse(Console.ReadLine());

            Console.Write("1 - Desconto\n2- Acréscimo\nDigite o número da operação que deseja fazer: ");
            var opcao = int.Parse(Console.ReadLine());

            string operacao = "";

            switch(opcao)
            {
                case 1:
                    operacao = "desconto";
                    break;
                case 2:
                    operacao = "acrescimo";
                    break;
            }

            Console.Write("Digite o percentual (%): ");
            var percentual = double.Parse(Console.ReadLine());

            Produto produto = new Produto(descricao,valorReal, operacao, percentual);

            var valorFinal = produto.OperacaoAExecutar(valorReal, percentual, operacao);
            Console.WriteLine($"O valor final do produto {descricao} é: R${valorFinal}");


        }
    }
}
