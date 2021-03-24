using Domain.Interfaces.Marcas;
using Entities;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository.Repositories
{
    class MarcaRepository : RepositoryGeneric<Marca>, IMarca
    {
    }
} 
