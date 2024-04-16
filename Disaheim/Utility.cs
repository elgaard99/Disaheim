using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {

        double lowQualityValue = 12.5;
        public double LowQualityValue {  get { return lowQualityValue; } set {  lowQualityValue = value; } }

        double mediumQualityValue = 20;
        public double MediumQualityValue { get { return mediumQualityValue; } set {  mediumQualityValue = value; } }

        double highQualityValue = 27.5;
        public double HighQualityValue { get { return highQualityValue; } set { highQualityValue = value; } }

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
                        amuletPrice = lowQualityValue;
                        break;

                    case Level.medium:
                        amuletPrice = mediumQualityValue;
                        break;

                    case Level.high:
                        amuletPrice = highQualityValue;
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
