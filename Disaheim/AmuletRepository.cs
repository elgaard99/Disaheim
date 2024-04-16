using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    internal class AmuletRepository
    {
        List<Amulet> amulets;

        public void AddAmulet(Amulet amulet)
        { amulets.Add(amulet); }

        public Amulet GetAmulet(string itemid)
        {
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemid)
                    return amulet;
            }

            return null;

        }

        public double GetTotalValue()
        {

            double total = 0;
            Utility utility = new Utility();

            foreach (Amulet amulet in amulets)
                total += utility.GetValueOfAmulet(amulet);

            return total;

        }
    }
}
