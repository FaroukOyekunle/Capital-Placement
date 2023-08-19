using System.Linq.Expressions;
using TaskConsole.Models;

namespace TaskProjectWebAPI.Interfaces.Repositories
{
    // The generic repository interface defines common CRUD operations for entities that inherit from BaseModel
    public interface IGenericRepository<T> where T : BaseModel
    {
        // Adds a new entity asynchronously to the repository
        Task<T> AddAsync(T entity);

        // Deletes an entity asynchronously from the repository
        Task DeleteAsync(T entity);

        // Retrieves an entity asynchronously by its Id
        Task<T> GetAsync(string id);

        // Retrieves all entities asynchronously from the repository
        Task<IEnumerable<T>> GetAllAsync();

        // Updates an entity asynchronously in the repository
        Task<T> UpdateAsync(T entity);

        // Retrieves an entity asynchronously based on a given expression
        Task<T> GetAsync(Expression<Func<T, bool>> expression);

        // Checks if any entity matches the given expression asynchronously
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    }
}
