using TaskConsole.Models;
using TaskProjectWebAPI.Context;
using TaskProjectWebAPI.Interfaces.Repositories;

namespace TaskProjectWebAPI.Implementations.Repositories
{
    public class StageRepository : GenericRepository<Stage>, IStageRepository
    {
        public StageRepository(ApplicationContext context) : base(context)
        {
            
        }
    }
}
