using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Casa
    {
        private double saldoCasa;

        public double ValorAluguel { get; set; }
        public double ValorInternet { get; set; }
        public double ValorEnergia { get; set; }
        public int ValorAgua { get; set; }
        public double ValorAlimentação { get; set; }            
        public double SaldoCasa { get; set; }

        public List<Produto> ListaDeCompras { get; set; }
        public List<Integrante> Integrantes { get; set; }



        public Casa(double valorEnergia, int valorAgua, double valorAlimentação, double saldoCasa, List<Produto> listaDeCompras, List<Integrante> integrantes)
        {
            ValorAluguel = 600.0;
            ValorInternet = 130.0;
            ValorEnergia = valorEnergia;
            ValorAgua = valorAgua;
            ValorAlimentação = valorAlimentação;
            SaldoCasa = saldoCasa;
            ListaDeCompras = listaDeCompras;
            Integrantes = integrantes;
        }
    }
}
