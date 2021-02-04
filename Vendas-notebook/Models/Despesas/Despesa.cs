using System;

namespace Vendas_notebook.Models
{
    public class Despesa
    {
        public Guid Id { get; set; }
        public TipoDespesa TipoDespesa  { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataDespesa { get; set; }
        public Produto? Produto { get; set; }
        
        public DateTime DataCriacao { get; set; }

        public Despesa()
        {
            DataCriacao = new DateTime();
        }
    }
}