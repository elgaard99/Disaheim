using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValueableRepository
    {
        List<IValueable> valueables = new List<IValueable>();

        public void AddValueable(IValueable valueable)
        { valueables.Add(valueable); }

        public IValueable GetValueable(string id)
        { 
            foreach (IValueable valueable in valueables) 
            { 
                if (valueable is Merchandise)
                {
                    Merchandise merchandise = (Merchandise)valueable;
                    if (merchandise.ItemId == id)
                        return merchandise;
                }
                
                else if (valueable is Course)
                {
                    Course course = (Course)valueable;
                    if (course.Name == id) 
                        return course;
                }
            }

            return null;

        }

        public double GetTotalValue()
        { 
            double total = 0;

            foreach (IValueable valueable in valueables)
                total += valueable.GetValue();

            return total;

        }
    }
}
