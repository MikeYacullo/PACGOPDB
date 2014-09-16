using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACGOPDB.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CardTypeID { get; set; }

        public virtual  CardType CardType{ get; set; }
    }
}