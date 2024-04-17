using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        int durationInMinutes;
        public int DurationInMinutes { get {  return durationInMinutes; } set {  durationInMinutes = value; } }

        public static double CourseHourValue { get; set; } = 875.0;

        public Course(string name) 
        { 
            Name = name;
            durationInMinutes = 0;
        }

        public Course(string name, int durationInMinutes) : this(name) 
        { 
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}, Value: {GetValue()}";
        }

        public string StringToSave()
        {
            return $"COURSE;{Name};{DurationInMinutes};{CourseHourValue}";
        }

        public double GetValue()
        {

            int hours = DurationInMinutes / 60;
            if (DurationInMinutes % 60 != 0)
                hours++;

            return hours * CourseHourValue;

        }
    }
}
