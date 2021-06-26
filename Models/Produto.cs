﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public abstract class Produto
    {
        protected string produtoNome;
        protected double valorTotal;

        public int ProdutoId { get; set; }
        public string Descricao { get; set; }

        public string ProdutoNome 
        {
            get => produtoNome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome do produto é Obrigatório!");

                produtoNome = value;
            }     
        }

        public virtual double ValorTotal { get; set; }

    }
}
