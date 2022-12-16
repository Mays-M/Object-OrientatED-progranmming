using System;

namespace MyApplication
{
    class CD
    {
        static void myArtist(string name, string artist)

        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Artist: " + artist);
           
            


        }
        public string name
        { get; set; }
        public string artist
        { get; set; }
        public double length
        { get; set; }
 

        static void Main(string[] args)
        {
            
            Console.WriteLine("You have a CD: ");
            CD cd =new CD();
            cd.name = "Endless Forms Most Beautiful";
            cd.artist = " Nightwish";
            CD newsong = new CD();
            CD newsong1 = new CD();
            CD newsong2 = new CD();
            newsong.name = "Shudder Before the Beautiful";
            newsong.length = 2.05;
            newsong1.name = "Weak Fantasy";
            newsong1.length = 6.05;
            newsong2.name = "Elan";
            newsong.length = 9.99;
            double totalsum = newsong.length + newsong1.length + newsong2.length;
            string [] array1 = { newsong.name + newsong.length, newsong1.name+ newsong1.length, newsong1.name +newsong.length };
            int result = array1.GetLength(0);
            myArtist(cd.name, cd.artist);
            Console.WriteLine("Total length: ** " +totalsum  +"**");
            Console.WriteLine(result +" Songs: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i] );
            }

           ;


        }
    }
}