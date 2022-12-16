
using System;
using System.Xml.Linq;

namespace MyApplication
{
    public class Electrical_Device   // Base class
    {
        public bool Switch { get; set; }             // Name method 

        public float Power { get; set; }          // Name method 

        public override string ToString()
        {
           
            return "Electrical Device: " + Switch + " Power" + Power;
        }
    }



    public class Radio : Electrical_Device  // Derived class
    {
        public string channel { get; set; }
        public int volume { get; set; }
        public float frequency { get; set; }
        public override string ToString()
        {
            return "Radio: " + channel + " Volume: " + volume + " Frequency: " + frequency;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object


            Electrical_Device myobj = new Electrical_Device { Switch = true, Power = 120 };
            Electrical_Device myobj1 = new Electrical_Device { Switch = false, Power = 120 };

            Radio myobj2 = new Radio { channel = "ON", volume = 3, frequency = 12000 };
            if (myobj1.Switch == false)
            {
                Console.WriteLine("Channel and Volume cann't be set because the Switch is set Off");
            }
            else
            Console.WriteLine(myobj2);

            





        }
    }
}

