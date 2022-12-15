using System;

namespace MyApplication
{
    class CD
    {
        static void myArtist(string artist,string name,string Genre, double price)

        {
            Console.WriteLine("Artist: " + artist );
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("price: " + "$" + price);
            
        }
        public string name
        { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("CD: ");
            myArtist("Nightwish", "Endless Forms Most Beautiful", "Symphonic metal", 19.9);
            CD songName1 = new CD();
            CD songName2 = new CD();
            CD songName3 = new CD();
            songName1.name = "Shudder Before the Beautiful";
            songName2.name = "Weak Fantasy";
            songName3.name = "Elan";
            Console.WriteLine("Songs: ");
            Console.WriteLine("Name: " + songName1.name);
            Console.WriteLine("Name: " + songName2.name);
            Console.WriteLine("Name: " + songName3.name);


        }
    }
}