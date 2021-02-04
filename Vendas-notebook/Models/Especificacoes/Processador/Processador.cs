using System;
using System.Security.AccessControl;
using GestaoVendas.Notebook.Models;

namespace Vendas_notebook.Models
{
    public class Processador
    {
        public Marca Marca { get; set; }
        public GeracaoProcessador GeracaoProcessador { get; set; }
    }


}