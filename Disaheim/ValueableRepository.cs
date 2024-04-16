using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValueableRepository
    {
        List<IValueable> valueables = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        { valueables.Add(merchandise); }

        public Merchandise GetMerchandise(string itemid)
        { 
            foreach (Merchandise merchandise in valueables) 
            { 
                if (merchandise.ItemId == itemid)
                    return merchandise;
            }

            return null;

        }

        public double GetTotalValue()
        { 
            double total = 0;
            Utility utility = new Utility();

            foreach (Merchandise merchandise in valueables)
                total += utility.GetValueOfMerchandise(merchandise);

            return total;

        }
    }
}
