using System.Data.Entity;

namespace MRF.Data
{
    public class DatabaseInitializer :
        DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
        }
    }
}