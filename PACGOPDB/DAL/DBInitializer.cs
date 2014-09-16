using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PACGOPDB.Models;

namespace PACGOPDB.DAL
{
    public class DBInitializer : System.Data.Entity.CreateDatabaseIfNotExists<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            var classDecks = new List<ClassDeck>{
                new ClassDeck{SeasonID=0,Name="Bard"},
                new ClassDeck{SeasonID=0,Name="Cleric"},
                new ClassDeck{SeasonID=0,Name="Fighter"},
                new ClassDeck{SeasonID=0,Name="Ranger"},
                new ClassDeck{SeasonID=0,Name="Rogue"},
                new ClassDeck{SeasonID=0,Name="Sorcerer"},
                new ClassDeck{SeasonID=0,Name="Wizard"}
            };
            classDecks.ForEach(s => context.ClassDecks.Add(s));
            context.SaveChanges();

            var seasons = new List<Season>{
                new Season{ID=0,Name="Season of the Shackles"}
            };
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();
        }
    }
}