

using System;
using System.Reflection;
using System.Xml.Linq;

namespace MyApplication
{
    abstract class Mammal
    {
        public int Age = 20;
        public abstract void Move();

    }
    class Human : Mammal
    {
        public string name;
        public float Heigh;
        public string gender;

        public override void Move()
        {
            Console.WriteLine("The Age of the peron: " + Age);
        }
        public void Grow()
        {
            Console.WriteLine("Gowth of the Human: {0}", Age + 1);
        }
    }
    class Baby : Human
    {
        public int Age;

        public override void Move()
        {
            Console.WriteLine("The Babies are Crawling");
        }
    }
    class Adult : Human
    {
        public string Auto;


        public override void Move()
        {
            Console.WriteLine("The Adult are Walking");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human myobj = new Human { };
            myobj.name = "Mays AL-Azzawi";
            myobj.Heigh = 164;
            myobj.gender = "Women";
            Console.WriteLine("Name_Person= " + myobj.name + " Heigh: " + myobj.Heigh + " Gender: " + myobj.gender);
            myobj.Move();
            myobj.Grow();
            Baby baby = new Baby();
            baby.Move();
            Adult adult = new Adult();
            adult.Move();

            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadLine();
        }
    }
}