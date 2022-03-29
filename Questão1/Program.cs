using Questão1.Classes;
using System;

namespace Questão1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pagamento com cartão\n\n");
            OpcaoBandeira();
            OpcaoDePagamento();

            Console.WriteLine($"{opcaoBandeira}");
                       
           /* if (opcaoBandeira == 1)
            {   
                
                var cartaoVisa = new CartaoBandeiraVisa();
            }
            if (opcaoBandeira == 2)
            {
                var cartaoMaster = new CartaoBandeiraMaster();
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }*/
                       



        }

        public static void OpcaoBandeira()
        {
            Console.WriteLine("Digite o número da opção da Bandeira do cartão");
            Console.WriteLine("1 - Visa \n2 - Master");
            int opcaoBandeira = int.Parse(Console.ReadLine());
        }
        
        public static void OpcaoDePagamento()
        {
            Console.WriteLine("Digite a numeração da opção de pagamento");
            Console.WriteLine("1 - Débito \n2- Crédito");
            int opcaoPagamento = int.Parse(Console.ReadLine());
        }

    }
}
