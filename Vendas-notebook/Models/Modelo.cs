using System;
using Vendas_notebook.Models;

namespace GestaoVendas.Notebook.Models
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public Marca Marca { get; set; }
        public Processador Processador { get; set; }
        public String ModeloDescricao { get; set; }

        public DateTime DataCriacao { get; set; }

        public Modelo()
        {
            this.DataCriacao = new DateTime();
        }
    }
}