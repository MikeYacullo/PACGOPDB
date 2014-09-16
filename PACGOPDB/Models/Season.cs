using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACGOPDB.Models
{
    public class Season
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClassDeck> ClassDecks { get; set; }
    }
}