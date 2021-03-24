using System;

namespace Entities
{
    public class Produto : BaseClass
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float Total { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataCompra { get; set; }
    }
}