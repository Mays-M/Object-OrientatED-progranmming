
using System;

namespace MyApplication
{
    class Tank
    {
        string Name;
        string Type;
        int CrewNumber=4;
        float Speed=0;
        float SpeedMax=100;

    public int NewCrewNumber
        
            { get ;set; }
    public int Newspeed

        { get; set; }


        static void AccelerateTo(float speed)
    {
        Console.WriteLine("The Accelertion of the  speed is " + speed);
    }
    static void SlowTo(float speed)
        {
        Console.WriteLine("The slow of the speed  is " + speed);
    }


        static void Main(string[] args)
        {
            
           
            Tank myobj = new Tank();
            myobj.Name = "Valvo";
            myobj.Type = "valvo 2006 grey";
            Console.WriteLine("Name: " + myobj.Name);
            Console.WriteLine("Type: " + myobj.Type);
            myobj.NewCrewNumber = 1;
            if (myobj.NewCrewNumber >=6 || myobj.NewCrewNumber <=2)
            { Console.WriteLine("CrewNumber: " + myobj.CrewNumber); }
            else
            {
                Console.WriteLine("CrewNumber: " + myobj.NewCrewNumber);
                
            }
            myobj.Newspeed = 80;
            if (myobj.Newspeed >= 100 || myobj.NewCrewNumber <= 0)
            {
                SlowTo(20);
                AccelerateTo(80);
            }
            else
            {
                Console.WriteLine("Speed: " + myobj.Newspeed);
            }
            Console.WriteLine("SpeedMax: " + myobj.SpeedMax);



        }
    }
}