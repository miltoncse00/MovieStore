using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Data.EntityF.DbEntity;
using MovieStore.Data.EntityF.DbManager;

namespace MovieStore.Data.EntityF.Migration
{
    public class Configuration: DbMigrationsConfiguration<DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MovieStore.Data.EntityF.DbManager.DB";
        }

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
