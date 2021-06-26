using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class ProdutoAçougue : Produto
    {
        private double valorDoKilo;
        private double quantidadeEmKG;
        public double QuantidadeEmKG
        {
            get => quantidadeEmKG;
            set
            {
                if (value <= 0.0)
                    throw new Exception("A quantidade de produtos não pode ser Menor ou igual a 0!");

                quantidadeEmKG = value;
            }
        }

        public double ValorDoKilo
        {
            get => valorDoKilo;
            set
            {
                if (value <= 0.0)
                    throw new Exception("O valor do kilo não pode ser Menor ou igual a 0!");

                valorDoKilo = value;
            }
        }

        public override double ValorTotal { get => ValorDoKilo * QuantidadeEmKG; }
    }
}
