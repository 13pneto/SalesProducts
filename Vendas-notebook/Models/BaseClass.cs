using System;

namespace Vendas_notebook.Models
{
    public class BaseClass
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }

        public BaseClass()
        {
            this.DataCriacao = DateTime.Now;
            this.Deletado = false;
            this.Id = Guid.NewGuid();
        }
    }
}
