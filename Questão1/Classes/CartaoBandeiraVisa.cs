using Questão1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1.Classes
{
    public class CartaoBandeiraVisa : IPagamentoCartao
    {
        private int TipoDePagamento { get; set; }
        private string BandeiraCartao { get; set; }

        public CartaoBandeiraVisa(int TipoDePagamento)
        {
            this.TipoDePagamento = TipoDePagamento;
            this.BandeiraCartao = "Visa";
        }

        public void pagamentoCredito()
        {
            Console.WriteLine($"Tipo de Pagamento: Crédito | Pago com Visa ");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine($"Tipo de Pagamento: Débito | Pago com Visa ");
        }
    }
}
