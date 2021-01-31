using System;

namespace GestaoVendas.Notebook.Models
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public Marca Marca { get; set; }
        public String ModeloDescricao { get; set; }

        public Modelo()
        {
            
        }
    }
}