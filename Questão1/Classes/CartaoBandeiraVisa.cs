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
        private string TipoDePagamento { get; set; }
        private string BandeiraCartao { get; set; }

        public CartaoBandeiraVisa(string TipoDePagamento)
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
            Console.WriteLine($"Tipo de Pagamento: Debito | Pago com Visa ");
        }
    }
}
