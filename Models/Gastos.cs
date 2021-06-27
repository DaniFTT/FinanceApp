using FinanceApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Gastos : IGastos
    {
        public int GastoId { get; set; }
        public string Descricao { get; set; }
        public virtual string TipoDoGasto { get; set; }
        public virtual double Valor { get; protected set; }
        public DateTime DataDaTransação { get; set; }
    }
}
