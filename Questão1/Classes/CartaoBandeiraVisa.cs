﻿using Questao1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1.Classes
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
            Console.WriteLine($"Tipo de Pagamento: {TipoDePagamento} | Pago com {BandeiraCartao} ");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine($"Tipo de Pagamento: {TipoDePagamento} | Pago com {BandeiraCartao} ");
        }
    }
}
