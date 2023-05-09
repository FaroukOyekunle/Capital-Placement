using ConsoleProject.Models;
using WebAPIProject.Context;
using WebAPIProject.Interfaces.Repositories;

namespace WebAPIProject.Implementations.Repositories
{
    public class ProgramRepository : GenericRepository<ConsoleProject.Models.Program>, IProgramRepository
    {
        public ProgramRepository(ApplicationContext context) : base(context)
        {
        }
    }
}