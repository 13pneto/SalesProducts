using System;


namespace Entities
{
    public class Venda : BaseClass
    {
        public Fornecedor Fornecedor { get; set; }
        public Cliente Cliente { get; set; }
        public Notebook Notebook { get; set; }
        public ContaBancaria ContaRecebimento { get; set; }

        public DateTime DataVenda { get; set; }

    }
}