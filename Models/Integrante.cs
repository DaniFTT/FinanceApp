using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Integrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double RendaTotal { get; set; }
        public List<GastosPessoais> ListaDeGastos { get; set; }

        public double ValorPCasa
        {
            get => RendaTotal * 0.35;
        }

        public Integrante(int id, string nome, double rendaTotal)
        {
            Id = id;
            Nome = nome;
            RendaTotal = rendaTotal;
        }

    }
}
