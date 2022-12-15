using System;
using System.Diagnostics.Metrics;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(int distance)
        {
            Console.WriteLine(distance);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance traveled: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            MyMethod(distance);
            int fuel_per_km = distance / 100;
            Random fuelprice = new Random();
            int fuelconsumed_lp100km = fuelprice.Next(6, 9);
            int fuel_consumed = fuel_per_km * fuelconsumed_lp100km;
            float fuelpriceestmated = 2.5F;
            float cost = fuel_consumed * fuelpriceestmated;
            Console.WriteLine("cost" + cost);






        }
    }
}