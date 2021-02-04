using System;

namespace Vendas_notebook.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float Total { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataCompra { get; set; }
    }
}