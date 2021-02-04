using System;

namespace Vendas_notebook.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Observacao { get; set; }
        
        public DateTime DataCriacao { get; set; }

        public Cliente()
        {
            this.DataCriacao = new DateTime();
        }
    }
}