
using System;

namespace MyApplication
{
    public class Employee  // Base class
    {
        public void Namemployee(string Name)             // Name method 
        {
            Console.Write("- Name: " + Name);
        }

        public void Proffission(string prof)             // profision method 
        {
            Console.Write(" Profision: " + prof);
        }
        public void Salary(float salary)             // salary method 
        {
            Console.Write(" Salary: " + salary);
        }
    }

    public class Boss : Employee  // Derived class
    {
        public void car(string NameModel)             // car method
        {
            Console.Write(" Car: " + NameModel);
        }
        public void Bouns(float bouns)             // bouns method 
        {
            Console.WriteLine(" Bouns: " + bouns);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Boss myobj = new Boss();

            // Call the honk() method (From the Vehicle class) on the myCar object
            Console.WriteLine("Employee: ");
            myobj.Namemployee(" Kirsi Kernel");
            myobj.Proffission("Teacher");
            myobj.Salary(1200);
            Console.WriteLine("");
            Console.WriteLine("Boss: ");
            myobj.Namemployee(" Hanna Husso");
            myobj.Proffission("Head of Institute");
            myobj.Salary(9000);
            myobj.car("Audi");
            myobj.Bouns(5000);
            Console.WriteLine("Employee: ");
            myobj.Namemployee(" Kirsi Kernel");
            myobj.Proffission("Principal Teacher");
            myobj.Salary(2200);





        }
    }
}
    
