using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{

    public class Controller
    {

        public List<IValueable> Valueables { get; set; }

        public Controller()
        { 
            Valueables = new List<IValueable>();
        }

        public void AddToList(IValueable valueable)
        {
            Valueables.Add(valueable);
        }
       
    }

}
