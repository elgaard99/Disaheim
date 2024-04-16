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

        public double MediumQualityValue { get; set; } = 20;

        public double HighQualityValue { get; set; } = 27.5;

        double courseHourValue = 875;
        public double CourseHourValue { get { return courseHourValue; } set {  courseHourValue = value; } }

        public double GetValueOfMerchandise(Merchandise merchandise)
        {

            if (merchandise is Book)
            {

                Book book = (Book)merchandise;
                return book.Price;

            }

            else if (merchandise is Amulet)
            {

                Amulet amulet = (Amulet)merchandise;

                double amuletPrice = -1;

                switch (amulet.Quality)
                {
                    case Level.low:
                        amuletPrice = LowQualityValue;
                        break;

                    case Level.medium:
                        amuletPrice = MediumQualityValue;
                        break;

                    case Level.high:
                        amuletPrice = HighQualityValue;
                        break;
                }

                return amuletPrice;

            }

            else
                return 0;
        }
    
        public double GetValueOfCourse(Course course) 
        {
            
            int hours = course.DurationInMinutes / 60;
            if (course.DurationInMinutes % 60 != 0)
                hours++;

            return hours * courseHourValue; 
        }

    }
}
