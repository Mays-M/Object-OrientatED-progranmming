
using System;

namespace MyApplication
{
    public class Vechile  // Base class
    {
        public void Namevechile(string Name)             // Name method 
        {
            Console.Write("- Name: " + Name);
        }
        public void Model(string model)             // Name method 
        {
            Console.Write(" Model: " + model);
        }

        public void ModelYear(int modelyear)             // profision method 
        {
            Console.Write(" ModelYear: " + modelyear);
        }
        public void Color(String color)             // salary method 
        {
            Console.Write(" Color: " + color);
        }
        public void GearWheels(bool wheel)             // Name method 
        {
            Console.Write(" GearWheels: " + wheel);
        }
        public void GearName(String gear)             // Name method 
        {
            Console.Write(" GearWheels: " + gear);
        }
    }

    public class Boat : Vechile  // Derived class
    {
        public void Seat(int seat)             // car method
        {
            Console.Write(" Seat: " + seat);
        }
        public void Type(string boatype)             // bouns method 
        {
            Console.WriteLine(" Boat Type: " + boatype);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            
            Boat myobj = new Boat();

            // Call the honk() method (From the Vehicle class) on the myCar object
            Console.WriteLine("Bike1 info: ");
            myobj.Namevechile("Jopo");
            myobj.Model("Street");
            myobj.ModelYear(2006);
            myobj.Color("Blue");
            myobj.GearWheels(false);             
            myobj.GearName("");
            Console.WriteLine("");
            Console.WriteLine("Bike2 info: ");
            myobj.Namevechile("Tunturi");
            myobj.Model("StreetMotor");
            myobj.ModelYear(2010);
            myobj.Color("Black");
            myobj.GearWheels(true);             // call methods
            myobj.GearName("Shimano Nexus");
            Console.WriteLine("");
            Console.WriteLine("Boat1 info: ");
            myobj.Namevechile("SummerFun");
            myobj.Model("S900");
            myobj.ModelYear(1900);
            myobj.Color("White");
            myobj.Seat(3);
            myobj.Type("Rowboat");
            Console.WriteLine("");
            Console.WriteLine("Boat2 info: ");
            myobj.Namevechile("Yamaha");
            myobj.Model("Model 1000");
            myobj.ModelYear(2010);
            myobj.Color("Yellow");
            myobj.Seat(5);
            myobj.Type("Motorboat");






        }
    }
}

