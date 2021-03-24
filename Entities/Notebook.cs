using System;
using System.Collections.Generic;


namespace Entities
{
    public class Notebook : BaseClass
    {
        public int Sequencia { get; set; }

        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }

        public bool? PrecisaArrumar { get; set; }
        public bool? Vendido { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime? DataVenda { get; set; }  //TODO Setar quando for vendido

        public List<Despesa> Despesas { get; set; }
    }
}