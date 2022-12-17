using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

class Player  // base class (parent) 
{
    public string fname;  // Vehicle field
    public string lname;
    public string gamelocation;
    public int number;

}

class Team: Player// derived class (child)
{
    public string Name; // Car field
    public string HomeTown;
    public List <string>Players;

    public Team (string team) => Nameteam = team;
      public string Nameteam
    {
        get => Name;
        set => Name = value;
    }

    }
class Program
{
    static void Main(string[] args)
    {
        List<string> mytires = new List<string>();
        // Create a myCar object
       Team player = new Team("llves");
        player.fname = "Ako";
        player.lname = "jsk";
        player.gamelocation = "Germany";
        player.number = 206;
        player.Name = "JYP";
        player.HomeTown = "spain";
        player.players(players.Add)

        List<string> teamplayer=new List<string>();
        teamplayer.Add




    }
}