using System.Linq.Expressions;
using System;
using ConsoleProject.Models;
using WebAPIProject.Interfaces.Repositories;
using WebAPIProject.Context;
using System.Data.Entity;

namespace WebAPIProject.Implementations.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>  where T: BaseModel , new()
    {
        protected ApplicationContext _context;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public  async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await  _context.Set<T>().AnyAsync(expression);
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetAsync(string id)
        {
            return await _context.Set<T>().FindAsync(id);
            
        }

        public async  Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).SingleOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
             _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
