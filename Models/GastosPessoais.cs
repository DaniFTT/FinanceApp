using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class GastosPessoais : Gastos
    {
        public override string TipoDoGasto { get; set; } = "Gasto Pessoal";
        public bool Mensal { get; set; }    
        public double ValorParcela { get; set; }
        public int Parcelas { get; set; }
        public override double Valor { get => ValorParcela * Parcelas; }
    }
}
