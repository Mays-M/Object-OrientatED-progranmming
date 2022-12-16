using System;
using System.Security.Cryptography.X509Certificates;

namespace BookShelf
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            Console.WriteLine("Book: ");
            return String.Format("Title : {0}\nAuthor : {1}\nPublished : {1}", Title, Author, Date.Year);
        }

    }
     public class Magazine : Book  // Derived class
    { 
        public string Publisher { get; set; }
     public override string ToString()
        {
            Console.WriteLine("Magazine: ");
            return String.Format("Publisher :  {0}\nPublished : {1}",Publisher , Date.Year);
        }

    }
    public class CDs : Book  // Derived class
    {
        public override string ToString()
        {
            return String.Format("Title : {0}\nAuthor : {1}\nPublished : {2}",Title, Author, Date.Year);
        }

    }
    public class Devices : Book // Derived class
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            Console.WriteLine("Devices: ");
            return String.Format("Type : {0}\nModel : {1}\nModelYear: {2}\nColor : {3}", Type, Model, ModelYear,Color);
        }

    }

    class Program
    {
        static void Main()
        {
            Book b = new Book {Title = "War and Pease", Author = "Leo Tolstoy",Date=new DateTime(1869, 1, 1) };
            Console.WriteLine(b);
            
            Magazine m = new Magazine { Publisher = "Madam Rianna", Date = new DateTime(2022, 1, 13) };
            Console.WriteLine(m);
            
            Devices d = new Devices {Type="Laptop" ,Model = "Acer 2900 ", ModelYear = 2020, Color = "Black" };
            Console.WriteLine(d);
            
        }
    }
}