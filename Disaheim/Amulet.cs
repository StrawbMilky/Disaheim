using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise //nedarver fra Merchandise klassen
    {
        public string Design { get; set; } //autoimplemented property
        public Level Quality { get; set; } //bruger level enum-klassen som data type

        public Amulet(string itemId) : base (itemId) //constructor overloading, forskellige instanstieringer af klassen ud fra forskellige parametre
        {
           this.ItemId = itemId;
        }
        public Amulet(string itemId, Level quality) : this(itemId)
        {
            this.ItemId = itemId;
            this.Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        {
            this.ItemId = itemId;
            this.Quality = quality;
            this.Design = design;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}
