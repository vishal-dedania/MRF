using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using MRF.Data.Configuration;
using MRF.Models;

namespace MRF.Data
{
    public class DataContext : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<TaxiRate> TaxiRates { get; set; }
        public DbSet<RideHistory> Rides { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"]
                    != null)
                {
                    return ConfigurationManager.
                        AppSettings["ConnectionStringName"];
                }

                return "DefaultConnection";
            }
        }

        static DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DataContext()
            : base(ConnectionStringName)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TaxiRateConfiguration());
            modelBuilder.Configurations.Add(new StateConfiguration());
            modelBuilder.Configurations.Add(new RideHistoryConfiguration());
        }

        private void ApplyRules()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(
                    e => e.Entity is IAuditInfo &&
                         (e.State == EntityState.Added) ||
                         (e.State == EntityState.Modified)))
            {
                IAuditInfo e = (IAuditInfo) entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    e.CreatedOn = DateTime.Now;
                }

                e.UpdatedOn = DateTime.Now;
            }
        }

        public override int SaveChanges()
        {
            ApplyRules();

            return base.SaveChanges();
        }
    }
}