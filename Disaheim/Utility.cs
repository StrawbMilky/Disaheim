using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook (Book book) //den skal modtage en instans af book, grøn er klassenavnet, blå er variabelnavnet
        {
            return book.Price;
        } 

        public double GetValueOfAmulet (Amulet amulet) 
        {
            double value = 0;

            switch (amulet.Quality)
            {
                case Level.low:
                    value = 12.5;
                    break;

                case Level.medium:
                    value = 20.0;
                    break;
                    
                case Level.high:
                    value = 27.5;
                    break;
            }
            return value;
        }

    }
}
