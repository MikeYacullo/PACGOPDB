using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PACGOPDB.Models;
namespace PACGOPDB.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DBContext")
        {

        }

        public DbSet<Card> Cards {get; set;}
        public DbSet<CardTrait> CardTraits {get; set;}
        public DbSet<CardType> CardTypes {get; set;}
        public DbSet<ClassDeck> ClassDecks {get; set;}
        public DbSet<ClassDeckCard> ClassDeckCards {get; set;}
        public DbSet<Season> Seasons {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}