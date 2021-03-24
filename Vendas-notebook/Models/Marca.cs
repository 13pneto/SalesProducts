using System;
using Vendas_notebook.Models;

namespace GestaoVendas.Notebook.Models
{
    public class Marca : BaseClass
    {
        public String MarcaNome { get; set; }
        public LinhaDeProdutos LinhaProdutos { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}