using Questao1.Classes;
using System;

namespace Questao1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool venda = true;

            do
            {
                Console.WriteLine("PAGAMENTO");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Digite o número da opção da Bandeira do cartão");
                Console.WriteLine("1 - Visa \n2 - Master");
                int opcaoBandeira = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a numeração da opção de pagamento");
                Console.WriteLine("1 - Débito \n2- Crédito");
                int opcaoPagamento = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (opcaoBandeira == 2 && opcaoPagamento == 1)
                {
                    CartaoBandeiraMaster master = new CartaoBandeiraMaster("Débito");
                    master.pagamentoDebito();
                }

                if (opcaoBandeira == 2 && opcaoPagamento == 2)
                {
                    CartaoBandeiraMaster master = new CartaoBandeiraMaster("Crédito");
                    master.pagamentoCredito();
                }

                if (opcaoBandeira == 1 && opcaoPagamento == 1)
                {
                    CartaoBandeiraVisa visa = new CartaoBandeiraVisa("Debito");
                    visa.pagamentoDebito();
                }

                if (opcaoBandeira == 1 && opcaoPagamento == 2)
                {
                    CartaoBandeiraVisa visa = new CartaoBandeiraVisa("Crédito");
                    visa.pagamentoCredito();
                }

                Console.WriteLine("");
                Console.WriteLine("Realizar outra venda?");
                Console.WriteLine("1 - Sim\n2 - Não");
                int outraVenda = int.Parse(Console.ReadLine());
                
                switch (outraVenda)
                {
                    case 1:
                        venda = true;
                        break;
                    case 2:
                        venda = false;
                        break;
                }

            } while (venda == true);                
        }      
    }
}
