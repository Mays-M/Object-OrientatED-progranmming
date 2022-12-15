using System;

namespace MyApplication
{
    class Kiuas 
    {
        float temperature;
        float humidity;

        static void Main(string[] args)
        {
            Kiuas myObj = new Kiuas();
            Kiuas myObj2 = new Kiuas();
            myObj.temperature = 120;
            myObj2.temperature = 80;
            myObj.humidity = 1200;
            myObj2.humidity = 1000;
            Console.WriteLine("The Temperature: " + myObj.temperature + " in celsius");
            Console.WriteLine("The Temperature: " + myObj2.temperature + " in celsius");
            Console.WriteLine("The Humidity: " +myObj.humidity);
            Console.WriteLine("The Humidity: " + myObj2.humidity);
        }
    }
}