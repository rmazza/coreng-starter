using Microsoft.AspNetCore.Http;
using CoreNg.Data;

namespace CoreNg.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DataRepository(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
        }
    }
}
