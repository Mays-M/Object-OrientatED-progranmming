using System;
using System.Xml.Linq;

namespace MyApplication
{
    class Vechiles
    {
        public String Brand { get; set; }
        public String Model { get; set; }
        public int Speed { get; set; }
        int tires { get; set; }
        static string ShowInfo(string brand, string model)
        {
            return "Vehicle manufacturer: Brand :" + brand + " and model information is " + model;
        }
        public override string ToString()
        {
            return "Vechiles Properties are :  Brand" + Brand + " Model: " + Model + " Speed" + Speed + " Tires: " + tires;
        }



        static void Main(string[] args)
        {
            Vechiles vechile = new Vechiles { Brand = "Car", Model = "Valvo2019", Speed = 240, tires = 4 };
            Vechiles vechile1 = new Vechiles { Brand = "Trank", Model = "Marced", Speed = 100, tires = 8 }; ;

            Console.WriteLine(ShowInfo("bicycle", "Jopo"));
            Console.WriteLine(vechile);
            Console.WriteLine(vechile1);


        }
    }
};
