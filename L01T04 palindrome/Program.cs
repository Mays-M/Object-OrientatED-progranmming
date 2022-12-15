using System;
using Microsoft.VisualBasic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your string and press enter
            Console.WriteLine("please, Enter a sentence or string: ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userinput = Console.ReadLine();

            char[] ch = userinput.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool b = userinput.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + userinput + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + userinput + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
