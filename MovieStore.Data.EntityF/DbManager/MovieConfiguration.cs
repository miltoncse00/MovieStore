using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MovieStore.Data.EntityF.DbEntity;
namespace MovieStore.Data.EntityF.DbManager
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Map(s => s.MapInheritedProperties());
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(t => t.Name).HasMaxLength(500).IsRequired();
            Property(t => t.Genre).IsRequired();
            Property(t => t.Rating).HasPrecision(10, 4);
            //  IndexingExtensions.HasIndex("IX_MOVIE_NAME_GENRE", IndexOptions.Nonclustered, 
            this.HasIndex("IX_MOVIE_NAME_GENRE", IndexOptions.Nonclustered, s => s.Property(e => e.Genre).HasColumnOrder(2),
                s => s.Property(e => e.Name).HasColumnOrder(1), s=>s.Property(r=>r.Rating));
        }
    }
}