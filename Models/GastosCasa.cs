using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class GastosCasa : Gastos
    {
        public override string TipoDoGasto { get; set; } = "Gasto de Casa";
    }
}
