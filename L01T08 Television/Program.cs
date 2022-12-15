using System;

namespace MyApplication
{
    class Television
    {
        bool Switch;
        String Model;
        String Color;
        int size;



        static void Main(string[] args)
        {
            Television myObj = new Television();
            Television myObj2 = new Television();
            myObj.Switch = true;
            myObj.Model = " LG20";
            myObj.Color = " Black";
            myObj.size = 42;
            myObj2.Switch = false;
            myObj2.Model = " Samsung";
            myObj2.Color = " White";
            myObj2.size = 52;
           
            Console.WriteLine("- The TV is turn ON " + ",The Model of the TV is :" + myObj.Model +
                    ", The TV Color is: " + myObj.Color + " ,and the size is: " + myObj.size + " inch");

            Console.WriteLine("-----------------Another Console--------------");
            
                
            Console.WriteLine("- The TV is turn OFF " + ",The Model of the TV is :" + myObj2.Model +
                        ", The TV Color is: " + myObj2.Color + " ,and the size is: " + myObj2.size + " inch");
               

                 

                
        }
        }
    }