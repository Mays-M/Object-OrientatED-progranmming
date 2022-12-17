

using System;

namespace MyApplication
{
    public class Refrigerator
    {
        public string Model;
        public void GetModel()
        {
            Console.WriteLine("Model: {0}", Model);
        }
    }
    public class vegtables : Refrigerator
    {
        public string Name_veg;
        public void GetNameVeg()
        {
            Console.WriteLine("Vegtables: {0}", Name_veg);
        }
    }
    public class Fruit : Refrigerator
    {
        public String Name_Fruit;
        public void GetNameFruit()
        {
            Console.WriteLine("fruit: {0}", Name_Fruit);
        }
    }
    public class meat : Refrigerator
    {
        public string Type;
        public void GetType()
        {
            Console.WriteLine("meat: {0}", Type);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Frigerator class contains : ");
            Fruit f = new Fruit();
            meat m = new meat();
            vegtables v = new vegtables();

            f.Model = "Swmsung";
            v.Name_veg = "Tamato";
            f.Name_Fruit = "Apple";
            m.Type = "fish";
            f.GetModel();
            v.GetNameVeg();
            f.GetNameFruit();
            m.GetType();
            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadLine();
        }
    }
}