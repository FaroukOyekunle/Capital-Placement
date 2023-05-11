using System.Linq.Expressions;
using TaskConsole.Models;
namespace TaskProjectWebAPI.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> UpdateAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    }
}
