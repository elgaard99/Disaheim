using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
       
        string design;
        public string Design { get { return design; } set { design = value; } }

        Level quality;
        public Level Quality {  get { return quality; } set {  quality = value; } }
        
        public Amulet(string itemId) : base(itemId)
        {  
            this.design = "";
            this.quality = Level.medium;
        }

        public Amulet(string itemId, Level quality) : this(itemId)
        {
            Quality = quality;
        }

        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        {
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {quality.ToString()}, Design: {design}";
        }
    }
}
