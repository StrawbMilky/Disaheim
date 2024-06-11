using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId) //base keyword bliver brugt når man gerne vil tilgå members fra base klassen, som er merchandise (mere specifikt fra constructeren i base klassen) 
        {
            this.ItemId = itemId;
        }
        public Book(string itemId, string title) : this(itemId) //this keyword 
        {
            this.Title = title;
        }
        public Book(string itemId, string title, double price) : this(itemId, title) //constructor overloading, se i amulet klassen for bedre forklaring
        {
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}"; //dollartegn betyder at man kan tilgå værdier inde i stringenkwd
        }
    }
}
