using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        { merchandises.Add(merchandise); }

        public Merchandise GetMerchandise(string itemid)
        { 
            foreach (Merchandise merchandise in merchandises) 
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

            foreach (Merchandise merchandise in merchandises)
                total += utility.GetValueOfMerchandise(merchandise);

            return total;

        }
    }
}
