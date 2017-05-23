using System.Data.Entity;
using MRF.Models;

namespace MRF.Data.Repositories
{
    public class StateRepository : GenericRepository<State>
    {
        public StateRepository(DbContext context) : base(context)
        {
        }
    }
}
