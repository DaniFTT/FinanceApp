using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class ProdutoMercado : Produto
    {
        private double valorUnidade;
        private int quantidade;
        public int Quantidade
        {
            get => quantidade;
            set
            {
                if (value <= 0)
                    throw new Exception("A quantidade de produtos não pode ser Menor ou igual a 0!");

                quantidade = value;
            }
        }

        public double ValorUnidade
        {
            get => valorUnidade;
            set
            {
                if (value <= 0.0)
                    throw new Exception("O valor do produto não pode ser Menor ou igual a 0!");

                valorUnidade = value;
            }
        }

        public override double ValorTotal { get => valorUnidade * quantidade;}
    }
}
