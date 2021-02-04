using System;

namespace Vendas_notebook.Models
{
    public class Memoria
    {
        public Guid Id { get; set; }
        public String Descricao { get; set; }
        public DDR GeracaoDDR { get; set; }
    }
    
    public enum DDR
    {
        DDR1 = 0,
        DDR2 = 1,
        DDR3 = 2,
        DDR4 = 3,
        DDR5 = 4
    }
}