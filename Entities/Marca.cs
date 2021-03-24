using System;

namespace Entities
{
    public class Marca : BaseClass
    {
        public string MarcaNome { get; set; }
        public LinhaDeProdutos LinhaProdutos { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}