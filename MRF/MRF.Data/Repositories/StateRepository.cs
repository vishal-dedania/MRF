using System.Data.Entity;
using MRF.Models;

namespace MRF.Data.Repositories
{
    public class StateRepository : GenericRepository<State>
    {
        public StateRepository(DataContext context) : base(context)
        {
        }
    }
}
