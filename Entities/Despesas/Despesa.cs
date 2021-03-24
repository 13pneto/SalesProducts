using System;

namespace Entities
{
    public class Despesa : BaseClass
    {
        public TipoDespesa TipoDespesa  { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataDespesa { get; set; }
        public Produto? Produto { get; set; }
    }
}