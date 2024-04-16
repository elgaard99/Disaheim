using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double amuletPrice = -1;

            switch (amulet.Quality)
            {
                case Level.low:
                    amuletPrice = 12.5;
                    break;

                case Level.medium:
                    amuletPrice = 20;
                    break;

                case Level.high:
                    amuletPrice = 27.5;
                    break;
            }

            return amuletPrice;
        }
    
        public double GetValueOfCourse(Course course) 
        {
            
            int hours = course.DurationInMinutes / 60;
            if (course.DurationInMinutes % 60 != 0)
                hours++;

            return hours * 875; 
        }

    }
}
