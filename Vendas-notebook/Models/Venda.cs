using System;
using System.Data.Common;

namespace Vendas_notebook.Models
{
    public class Venda
    {
        public Guid Id { get; set; }
        public int Sequencia { get; set; }
        
        public Fornecedor? Fornecedor { get; set; }
        public Cliente? Cliente { get; set; }
        public Notebook Notebook { get; set; }

        public DateTime DataVenda { get; set; }

    }
}