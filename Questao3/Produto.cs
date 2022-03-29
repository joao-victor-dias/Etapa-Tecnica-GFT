using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double ValorReal { get; set; }
        public string Operacao { get; set; }
        public double Percentual { get; set; }
        public double ValorFinal { get; set; }

        public Produto(string Descricao, double ValorReal, string Operacao, double Percentual)
        {
            this.Descricao = Descricao;
            this.ValorReal = ValorReal; 
            this.Operacao = Operacao;
            this.Percentual = Percentual;
            this.ValorFinal = ValorFinal;
            
        }

        public double OperacaoAExecutar(double ValorReal,double Percentual,string Operacao)
        {
            double valorFinal = 0;
            if (Operacao.ToLower() == "desconto")
            {
                valorFinal = ValorReal - (ValorReal*(Percentual/100));                
            }
            if (Operacao.ToLower() == "acrescimo")
            {
                valorFinal = ValorReal + (ValorReal * (Percentual / 100));
            }

            return valorFinal;
        }



    }
}
