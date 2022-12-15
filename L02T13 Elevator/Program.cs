using System;

namespace program
{
    public class Elevator
    {
        int floor = 1;
        public void GoTo(int floor, int message)
        {
            Console.WriteLine("Elevator is now in floor : " + message);
            Console.Write("Give a new floor number (1-5): " + floor);


        }
        public int CurrentFloor { get; set; }


       

 

        //Button to close the doors
      
        static void Main(string[] args)
        {
            Elevator myobj = new Elevator();
            Console.WriteLine("Elevator is now in floor :" + myobj.floor);
            bool t = true;
            while (t)
            {
                Console.Write("Give a new floor number (1-5) >: ");
                int  newfloor = Convert.ToInt16(Console.ReadLine());
                
                if (newfloor == 0)
                {
                    t = false;
                }
                else if (newfloor >5)
                {
                    Console.WriteLine("Floor is too big!");

                }
                else if (newfloor < 0)
                {
                    Console.WriteLine("Floor is too Small!");

                }
                else
                {
                  
                    myobj.GoTo(myobj.floor,newfloor);
                    t = true;

                }




            }
        }
    }
}