using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACGOPDB.Models
{
    public class ClassDeck
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SeasonID { get; set; }

        public virtual Season Season { get; set; }  

    }
}