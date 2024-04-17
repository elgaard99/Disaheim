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
        
        public static double LowQualityValue { get; set; } = 12.5;

        public static double MediumQualityValue { get; set; } = 20;

        public static double HighQualityValue { get; set; } = 27.5;

        public Amulet(string itemId)
        {  
            ItemId = itemId;
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

        public override double GetValue()
        {

            double amuletPrice = -1;

            switch (Quality)
            {
                case Level.low:
                    amuletPrice = LowQualityValue;
                    break;

                case Level.medium:
                    amuletPrice = MediumQualityValue;
                    break;

                case Level.high:
                    amuletPrice = HighQualityValue;
                    break;
            }

            return amuletPrice;

        }
    }
}
