using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingCSV;

class Player  // base class (parent) 
{
    public string fname { get; set; }// Vehicle field
    public string lname { get; set; }
    public string Gamelocation { get; set; }
    public int number { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        var mylist = new List<Player>()
      {
          new Player {fname="Jarkko" , lname = "Immonen" , Gamelocation = "center" , number = 26},
          new Player { fname = "Bard" , lname = "Lambert" , Gamelocation = "forward" , number = 16}

};

        using (var writer = new StreamWriter("filePlayers.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(mylist);
        }



    }
}
