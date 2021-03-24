using System;
using Vendas_notebook.Models;

namespace GestaoVendas.Notebook.Models
{
    public class Modelo: BaseClass
    {
        public Marca Marca { get; set; }
        public Processador Processador { get; set; }
        public String ModeloDescricao { get; set; }
    }
}