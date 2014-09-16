using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACGOPDB.Models
{
    public class CardType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}