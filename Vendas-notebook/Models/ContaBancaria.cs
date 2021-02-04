using System;

namespace Vendas_notebook.Models
{
    public class ContaBancaria
    {
        public Guid Id { get; set; }
        public String Conta { get; set; }
        
        public DateTime DataCriacao { get; set; }

        public ContaBancaria()
        {
            this.DataCriacao = new DateTime();
        }
    }
}