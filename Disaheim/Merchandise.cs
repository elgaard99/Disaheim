using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        string itemId;
        public string ItemId { get { return itemId; } set { itemId = value; } }

        public override string ToString()
        {
            return "ItemId: " + itemId;
        }

        public abstract double GetValue();

        public abstract string StringToSave();

    }
}
