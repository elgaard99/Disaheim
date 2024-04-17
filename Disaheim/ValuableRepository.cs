using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valueable)
        { valuables.Add(valueable); }

        public IValuable GetValuable(string id)
        { 
            foreach (IValuable valueable in valuables) 
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

            foreach (IValuable valueable in valuables)
                total += valueable.GetValue();

            return total;

        }

        public int Count()
        {
            return valuables.Count;
        }
    }
}
