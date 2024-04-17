using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.IO.Enumeration;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
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

        public void Save(string fileName = "ValuableRepository.txt")
        {

            StreamWriter writer = new StreamWriter(fileName);
            
            try
            {
                foreach (IValuable valuable in valuables)
                    writer.WriteLine(valuable.StringToSave());
            
            }
            catch (Exception ex)
            { throw ex; }

            finally 
            { writer.Close(); }
            
        }

        public void Load(string fileName = "ValuableRepository.txt")
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] valuableData = line.Split(";");

                switch (valuableData[0]) 
                {
                    case "BOOK":
                        AddValuable(new Book(
                            itemId: valuableData[1],
                            title: valuableData[2],
                            price: Convert.ToDouble(valuableData[3])));
                        break;

                    case "AMULET":

                        Level q;
                        Enum.TryParse(valuableData[3], out q);

                        Amulet amulet = new Amulet(
                            itemId: valuableData[1],
                            design: valuableData[2],
                            quality: q);

                        AddValuable(amulet);
                        break;

                    case "COURSE":
                        AddValuable(new Course(
                            name: valuableData[1],
                            durationInMinutes: int.Parse(valuableData[2])));
                        break;
                }
            }
                
        }

    }
}
