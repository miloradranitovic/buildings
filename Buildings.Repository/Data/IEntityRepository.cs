using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Buildings.Domain.Data
{
    public interface IEntityRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task InsertAsync(T obj);

        Task UpdateAsync(T obj);

        void Delete(Guid id);
    }
}
