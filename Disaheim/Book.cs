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

        public Book (string itemId) //constructor overloading, se i amulet klassen for bedre forklaring
        {
            this.ItemId = itemId;
        }
        public Book(string itemId, string title)
        {
            this.ItemId = itemId;
            this.Title = title;
        }
        public Book(string itemId, string title, double price)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}"; //dollartegn betyder at man kan tilgå værdier inde i stringenkwd
        }
    }
}
