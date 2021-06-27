using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Casa
    {
        public double ValorAluguel { get; set; }
        public double ValorInternet { get; set; }
        public double ValorEnergia { get; set; }
        public int ValorAgua { get; set; }
        public double ValorAlimentação { get; set; }            
        public double ValorGas{ get; set; }     
        
        public double SaldoCasa { get; set; }

        public List<Produto> ListaDeCompras { get; set; }
        public List<Integrante> Integrantes { get; set; }






        public double CalculaSaldoCasa(List<Integrante> integrantes)
        {
            double valor = 0;
            foreach (var integrante in integrantes)
            {
                valor += integrante.ValorPCasa;
            }   
            return valor;
        }
    }
}
