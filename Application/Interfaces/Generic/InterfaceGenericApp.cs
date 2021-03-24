using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Generic
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add(T obj);
        Task Update(T obj);
        Task Delete(T obj);
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
    }

}
