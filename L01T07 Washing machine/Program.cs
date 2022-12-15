using System;

namespace MyApplication
{
    class Wash
    {
        bool Switch ;
        String Message;



        static void Main(string[] args)
        {
            Wash myObj1 = new Wash();
            Wash myObj2 = new Wash();
            myObj1.Switch = true;
            myObj2.Switch = false;
            myObj1.Message = " The switch is ON the  machine is starting to wash";
            myObj2.Message = " The switch is OFF so machine can't start washing";
            if ((myObj1.Switch) == true)
            {
                Console.WriteLine(myObj1.Message);
            }
            else
            {
                Console.WriteLine(myObj2.Message);

            }
            Console.WriteLine("----------- Another console--------------");

            if ((myObj2.Switch) == false)
            {
                Console.WriteLine(myObj2.Message);
            }
            else
            {
                Console.WriteLine(myObj1.Message);


            }
        }
    }
}