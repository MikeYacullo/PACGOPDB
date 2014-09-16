using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACGOPDB.Models
{
    public class ClassDeckCard
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public int CardID { get; set; }
        public int ClassDeckID { get; set; }
        public int Count { get; set; }

        public virtual Card Card { get; set; }
        public virtual ClassDeck ClassDeck { get; set; }
        public virtual ICollection<CardTrait> CardTraits {get; set;}

    }
}