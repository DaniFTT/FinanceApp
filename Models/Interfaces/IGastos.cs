using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models.Interfaces
{
    public interface IGastos
    {
        int GastoId { get; set; }
        string NomeGasto { get; set; }
        string TipoDoGasto { get; set; }
        double Valor { get; }
        DateTime DataDaTransação { get; set; }
    }
}
