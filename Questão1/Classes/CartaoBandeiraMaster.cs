using Questão1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1.Classes
{
    public class CartaoBandeiraMaster : IPagamentoCartao
    {
        private string TipoDePagamento { get; set; }
        private string BandeiraCartao { get; set; }

        public CartaoBandeiraMaster(string TipoDePagamento)
        {
            this.TipoDePagamento = TipoDePagamento;
            this.BandeiraCartao = "Master";
        }
        
        public void pagamentoCredito()
        {
            Console.WriteLine($"Tipo de Pagamento: Crédito | Pago com Master ");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine($"Tipo de Pagamento: Debito | Pago com Master ");
        }
    }
}
