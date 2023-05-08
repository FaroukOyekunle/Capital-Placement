using ConsoleProject.Models;
using WebAPIProject.Context;
using WebAPIProject.Interfaces.Repositories;

namespace WebAPIProject.Implementations.Repositories
{
    public class ApplicationRepository : GenericRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
