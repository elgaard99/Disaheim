using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    internal class BookRepository
    {
        List<Book> books;

        public void AddBook(Book book)
        { books.Add(book); }

        public Book GetBook(string itemid)
        { 
            foreach (Book book in books) 
            { 
                if (book.ItemId == itemid)
                    return book;
            }

            return null;

        }

        public double GetTotalValue()
        { 
            double total = 0;
            Utility utility = new Utility();

            foreach (Book book in books)
                total += utility.GetValueOfBook(book);

            return total;

        }
    }
}
