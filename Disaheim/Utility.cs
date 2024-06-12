using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue { get; set; } = 12.5; 
        public double MediumQualityValue { get; set; } = 20.0;
        public double HighQualityValue { get; set; } = 27.5;
        public double CourseHourValue { get; set; } = 875.0;

        public double GetValueOfMerchandise (Merchandise merchandise)
        {
            if (merchandise is Book book)
            {
                return book.Price;
            }
            else if (merchandise is Amulet amulet)
            {
                double value = 0;

                switch (amulet.Quality)
                {
                    case Level.low:
                        value = LowQualityValue;
                        break;

                    case Level.medium:
                        value = MediumQualityValue;
                        break;

                    case Level.high:
                        value = HighQualityValue;
                        break;
                }
                return value;
            }
            return 0;
        }

        public double GetValueOfCourse(Course course) //metode
        {
            double value = CourseHourValue;

            int hours = course.DurationInMinutes/60; //finder antal timer ved at dividere heltallet med 60

            int minutes = course.DurationInMinutes %60; //finder restdelen af minutterne efter at de er blevet divideret med 60, og der vises det antal minutter der er udover de beregnede timer  

            if (minutes > 0)
            {
                minutes = 1;

                return (hours + minutes) * value;
            }
            else
            {
                return hours * value;
            }
        }
    }
}
