using MovieStore.Data.EntityF.DbEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure.Annotations;
using MovieStore.Data.EntityF.Migration;

namespace MovieStore.Data.EntityF.DbManager
{
    public class DB : DbContext
    {
        public DB() : base("DefaultConnection")
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DB,Configuration >());
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Director> Directors { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DbSetValuesWhenNotExist : DropCreateDatabaseIfModelChanges<DB>
    {
        protected override void Seed(DB context)
        {
            IList<Producer> producers = new List<Producer>()
            {
                new Producer(){Id = Guid.NewGuid(), Name = "Producer 1" , BirthDate = DateTime.Now.AddYears(-30)},
                new Producer(){Id = Guid.NewGuid(), Name = "Producer 2" , BirthDate = DateTime.Now.AddYears(-30)},
                new Producer(){Id = Guid.NewGuid(), Name = "Producer 3" , BirthDate = DateTime.Now.AddYears(-30)},
                new Producer(){Id = Guid.NewGuid(), Name = "Producer 4" , BirthDate = DateTime.Now.AddYears(-30)}
            };
            foreach (var producer in producers)
            {
                context.Producers.Add(producer);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
