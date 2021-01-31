using System;

namespace Vendas_notebook.Models
{
    public class Despesa
    {
        public Guid Id { get; set; }
        public TipoDespesa TipoDespesa  { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataDespesa { get; set; }
    }
}