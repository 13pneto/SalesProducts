namespace Entities
{
    public class Armazenamento: BaseClass
    {
        public TipoArmazenamento Tipo { get; set; }
        public int QuantidadeGB { get; set; }
    }

    public enum TipoArmazenamento
    {
        HDD = 1,
        SSD_SATA = 2,
        SSD_NVME = 3,
        SSD_HIBRIDO = 4
    }
}