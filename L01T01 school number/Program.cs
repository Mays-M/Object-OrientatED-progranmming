using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade:");

            bool Valid = false;
            int number = 0;
            int grade = 0;
            while (Valid)
            {
                string userinput = Console.ReadLine();
                if (int.TryParse(userinput, out number))
                {
                    grade = number;
                    Valid = false;

                }
                else
                {
                    Console.Write("not a number, please try again");


                }
            }
            grade = Convert.ToInt32(Console.ReadLine());


            if (grade == 0 || grade <= 19)
            {
                Console.WriteLine("Your grade is : 0");
            }
            else if (grade == 20 || grade <= 29)
            {
                Console.WriteLine("Your grade is : 1");
            }
            else if (grade == 30 || grade <= 39)
            {
                Console.WriteLine("Your grade is : 2");
            }
            else if (grade == 40 || grade <= 49)
            {
                Console.WriteLine("Your grade is : 3");
            }
            else if (grade == 50 || grade <= 59)
            {
                Console.WriteLine("Your grade is : 4");
            }
            else if (grade == 60 || grade <= 70)
            {
                Console.WriteLine("Your grade is : 5");
            }

        }
    }
}


