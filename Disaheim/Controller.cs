using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        List<Book> books;
        public List<Book> Books {  get {  return books; } set { books = value; } }

        List<Amulet> amulets;
        public List<Amulet> Amulets { get { return amulets; } set { amulets = value; } }

        List<Course> courses;
        public List<Course> Courses { get { return courses; } set { courses = value; } } 

        public Controller()
        { 
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
        }

        public void AddToList(Book book)
        {
            books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public void AddToList(Course course)
        {
            courses.Add(course);
        }

    }
}
