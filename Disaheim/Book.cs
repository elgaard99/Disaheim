using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {

        string title;
        public string Title { get { return title; } set { title = value; } }

        double price;
        public double Price { get { return price; } set { price = value; } }

        public Book(string itemId)
        {
            ItemId = itemId;
            this.title = "";
            this.price = 0;
        }

        public Book(string itemId, string title) : this(itemId)
        {
            Title = title;
        }

        public Book(string itemId, string title, double price) : this(itemId, title)
        {
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {title}, Price: {price}";
        }

        public override double GetValue()
        {
            
            return Price;

        }

    }

}
