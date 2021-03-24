using Application.Interfaces.Generic;
using Domain.Interfaces.Marcas;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.OpenAPP
{
    public class MarcaAPP : IMarcaAPP
    {
        private readonly IMarca _IMarca;

        public MarcaAPP(IMarca iMarca)
        {
            _IMarca = iMarca;
        } 

        public async Task Add(Marca obj)
        {
            await _IMarca.Add(obj);
        }

        public async Task Delete(Marca obj)
        {
            await _IMarca.Delete(obj);
        }

        public async Task<List<Marca>> GetAll()
        {
            return await _IMarca.GetAll();
        }

        public async Task<Marca> GetById(Guid id)
        {
            return await _IMarca.GetById();
        }

        public async Task Update(Marca obj)
        {
            await _IMarca.Update(obj);
        }
    }
}
