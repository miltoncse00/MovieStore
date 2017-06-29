using System.Configuration;
using MoveStore.Data.Common.Interfaces;
using MovieStore.Data.EntityF.DbEntity;

namespace MovieStore.Data.EntityF.DbManager
{
    public sealed class MoveStoreDbContext:UnityOfWork, IMovieStoreDbContext
    {
        public IDbRepository<Movie> Movie { get; set; }
        public IDbRepository<Director> Director { get; set; }
        public IDbRepository<Producer> Producer { get; set; }

        public MoveStoreDbContext():base()
        {
           
            Movie = new DbRepository<Movie>(Context.Set<Movie>());
            Director = new DbRepository<Director>(Context.Set<Director>());
            Producer = new DbRepository<Producer>(Context.Set<Producer>());
        }
    }

    public interface IMovieStoreDbContext
    {
         IDbRepository<Movie> Movie { get; set; }
         IDbRepository<Director> Director { get; set; }
         IDbRepository<Producer> Producer { get; set; }
    }
}
