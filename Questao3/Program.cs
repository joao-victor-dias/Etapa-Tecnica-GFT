using System;

namespace Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Aplicação de desconto ou acréscimo");

            var produto1 = new Produto("Tapete", 22.5, "acrescimo", 10);
            var valorFinal1 = produto1.OperacaoAExecutar(produto1.ValorReal, produto1.Percentual, produto1.Operacao);
            Console.WriteLine(valorFinal1);

            var produto2 = new Produto("Panela", 12.5, "desconto", 10);
            var valorFinal2 = produto2.OperacaoAExecutar(produto2.ValorReal, produto2.Percentual, produto2.Operacao);
            Console.WriteLine(valorFinal2);





        }
    }
}
