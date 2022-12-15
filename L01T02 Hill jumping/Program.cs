using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give points: ");
            int point1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give points: ");
            int point2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give points: ");
            int point3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give points: ");
            int point4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give points: ");
            int point5 = Convert.ToInt32(Console.ReadLine());
            int[] mylist = { point1, point2, point3, point4, point5 };
            int maxpoint = mylist.Max();
            int minpoint = mylist.Min();
            int totalpoints = mylist.Sum() - mylist.Max() - mylist.Min();

            Console.WriteLine("Your points is: " + totalpoints);
        }
    }
}