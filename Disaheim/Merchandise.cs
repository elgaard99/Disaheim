using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Merchandise
    {
        string itemId;
        public string ItemId { get { return itemId; } set { itemId = value; } }

        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }

        public override string ToString()
        {
            return "ItemId: " + itemId;
        }
    }
}
