using System;

namespace Vendas_notebook.Models
{
    public class Armazenamento
    {
        public Guid Id { get; set; }
        public TipoArmazenamento Tipo { get; set; }
        public int QuantidadeGB { get; set; }
    }

    public enum TipoArmazenamento
    {
        HDD = 1,
        SSD_SATA = 2,
        SSD_NVME = 3
    }
}