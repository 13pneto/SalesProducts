using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    public class BaseContext : DbContext
    {

        public BaseContext(DbContextOptions<BaseContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionSql());
            }
        }

        private string GetStringConnectionSql()
        {
            return "Data Source =PEDRONETO; Initial Catalog = Vendas_Notebooks; Integrated Security = True";
            
        }

    }
}
