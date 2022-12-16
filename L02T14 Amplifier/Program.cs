using System;

namespace program
{
    public class Amplifier
    {
        int volume ;
        public void Volume(int volume, int message)
        {
            Console.WriteLine("Amplifier volume is set to: " + message);
            Console.Write("Give a new volume value (0-100) > " + volume);


        }
        public int CurrentVolum { get; set; }
        public int MaxVolume { get ; set; }
        public int MinVolume { get; set; }



        static void Main(string[] args)
        {
            Amplifier myobj = new Amplifier();
            bool t = true;
            while (t)
            {
                Console.Write("Give a new volume value (0-100) >  ");
                int newvolume = Convert.ToInt16(Console.ReadLine());

                if (newvolume > 100)
                {
                    newvolume = 100;
                    Console.WriteLine(" Too much volume - Amplifier volume is set to maximum : " +newvolume);

                }
                else if (newvolume < 0)
                {
                    newvolume = 0;
                    Console.WriteLine(" Too low volume - Amplifier volume is set to minimum : " +newvolume);

                }
                else
                {

                    myobj.Volume(myobj.volume, newvolume);
                    t = true;

                }




            }
        }
    }
}