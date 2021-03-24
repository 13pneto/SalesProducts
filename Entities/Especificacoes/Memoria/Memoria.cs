using System;

namespace Entities
{
    public class Memoria : BaseClass
    {
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