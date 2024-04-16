using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        
        List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        { courses.Add(course); }

        public Course GetCourse(string itemid)
        {

            foreach (Course course in courses)
            {
                if (course.Name == itemid)
                    return course;
            }

            return null;

        }

        public double GetTotalValue()
        {

            double total = 0;
            Utility utility = new Utility();

            foreach (Course course in courses)
                total += utility.GetValueOfCourse(course);

            return total;

        }
    }
}
