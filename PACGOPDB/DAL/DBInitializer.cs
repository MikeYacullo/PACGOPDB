using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PACGOPDB.Models;

namespace PACGOPDB.DAL
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            var seasons = new List<Season>{
                new Season{ID=1,Name="Season of the Shackles"}
            };
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();

            var classDecks = new List<ClassDeck>{
                new ClassDeck{SeasonID=1,Name="Bard"},
                new ClassDeck{SeasonID=1,Name="Cleric"},
                new ClassDeck{SeasonID=1,Name="Fighter"},
                new ClassDeck{SeasonID=1,Name="Ranger"},
                new ClassDeck{SeasonID=1,Name="Rogue"},
                new ClassDeck{SeasonID=1,Name="Sorcerer"},
                new ClassDeck{SeasonID=1,Name="Wizard"}
            };
            classDecks.ForEach(s => context.ClassDecks.Add(s));
            context.SaveChanges();

            var cardTypes = new List<CardType>{
                new CardType{Name="Weapon"},
                new CardType{Name="Spell"},
                new CardType{Name="Armor"},
                new CardType{Name="Item"},
                new CardType{Name="Ally"},
                new CardType{Name="Blessing"}
            };
            cardTypes.ForEach(s=>context.CardTypes.Add(s));
            context.SaveChanges();

            var cardTraits = new List<CardTrait>{
                new CardTrait{Name="Basic"}
            };
            cardTraits.ForEach(s => context.CardTraits.Add(s));
            context.SaveChanges();
            
        }
    }
}