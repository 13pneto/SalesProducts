using System;
using System.Collections.Generic;
using System.Security.Principal;
using GestaoVendas.Notebook.Models;

namespace Vendas_notebook.Models
{
    public class Notebook
    {
        public Guid Id { get; set; }
        public int Sequencia { get; set; }
        
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }

        public Boolean PrecisaArrumar { get; set; }
        public Boolean Vendido { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataVenda { get; set; }  //TODO Setar quando for vendido
        
        public List<Despesa> Despesas { get; set; }

        public Notebook()
        {
            this.DataCompra = new DateTime();
        }
    }
}