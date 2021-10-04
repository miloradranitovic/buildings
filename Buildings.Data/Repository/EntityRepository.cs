using Buildings.Domain.Data;
using Buildings.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Buildings.Data.Repository
{
    public class EntityRepository <T> : IEntityRepository <T> where T : IEntity
    {
        private UpravnikContext _context = null;
        private DbSet<T> _table = null;
        public EntityRepository(UpravnikContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }
        public async Task InsertAsync(T obj)
        {
            await _table.AddAsync(obj);
        }
        public async Task UpdateAsync(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(Guid id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
