using System;

namespace Vendas_notebook.Models
{
    public class Especificacoes
    {
        public Guid Id { get; set; }
        public Processador Processador { get; set; }
        public Memoria Memoria { get; set; }
        public Armazenamento Armazenamento { get; set; }
    }
}