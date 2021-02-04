using System;

namespace Vendas_notebook.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public String RazaoSocial { get; set; } //RazaoSocial ou Nome
        public String Telefone { get; set; }
        
        public TipoFornecedor Tipo { get; set; }
        public TipoRetirada TipoRetirada { get; set; }
        public String? EnderecoRetirada { get; set; } //Apenas se TipoRetirada = 0 ou 1
        
        public String Observacao { get; set; }
        
        public DateTime DataCriacao { get; set; }
        
        public Fornecedor()
        {
            this.DataCriacao = new DateTime();
        }
        
    }
    
    public enum TipoFornecedor
    {
        Notebook = 0,
        Pecas = 1,
        Servico = 2
    }

    public enum TipoRetirada
    {
        Retirada = 0,
        EntregaCliente = 1,
        EntregaFornecedor = 2
    }
    
}