using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaheimTest
{
    public class Course
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        int durationInMinutes;
        public int DurationInMinutes { get {  return durationInMinutes; } set {  durationInMinutes = value; } }

        public Course(string name) 
        { 
            Name = name;
            durationInMinutes = 0;
        }

        public Course(string name, int durationInMinutes) : this(name) 
        { 
            DurationInMinutes = durationInMinutes;
        }
    }
}
