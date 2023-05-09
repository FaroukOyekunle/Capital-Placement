using TaskConsole.Models;
using TaskProjectWebAPI.Context;
using TaskProjectWebAPI.Interfaces.Repositories;

namespace TaskProjectWebAPI.Implementations.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
