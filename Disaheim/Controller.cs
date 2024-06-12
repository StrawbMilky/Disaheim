using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public List<Book> Books = new List<Book>(); //laver en liste over Book
        public List<Amulet> Amulets = new List<Amulet>();
        public List<Course> Courses = new List<Course>();

        public Controller() { }
        public void AddToList(Book book) { Books.Add(book);} //void da DCD viser at den ikke har en return type, den modtager en instans (lyseblåt) fra book klassen (grønt) og tilføjer instansen til Books listen med Add() funktionen
        public void AddToList(Amulet amulet) {  Amulets.Add(amulet);}
        public void AddToList(Course course) {  Courses.Add(course);}
    }
}
