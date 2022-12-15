using System;
using System.Xml.Linq;

namespace MyApplication
{
    class Students
    {
        public String Name { get; set; }
        
        public int  Degree { get; set; }
     
        public override string ToString()
        {
            return "Student: Name" + Name + " GPA: " + "Degree: " + Degree;
        } 
    


        static void Main(string[] args)
            {
               Students student = new Students { Name="Mays",Degree=2};
            Students student1 = new Students { Name = "Eeva",  Degree = 1 };
            Students student2= new Students { Name = "JoniK",Degree = 4 };
            Students student3 = new Students { Name = "Shahad", Degree = 3 };
            Students student4 = new Students { Name = "Iiro",  Degree = 2 };

            {
                Dictionary<string, Int32> namedegree = new Dictionary<string, Int32>();
                namedegree.Add(student.Name,student.Degree);
                namedegree.Add(student1.Name, student1.Degree);
                namedegree.Add(student2.Name, student2.Degree);
                namedegree.Add(student3.Name, student3.Degree);
                namedegree.Add(student4.Name, student4.Degree);



                for (int i = 0; i < namedegree.Count; i++)
                {
                    Console.WriteLine($"The student: Name:{namedegree.ElementAt(i).Key} Degree:  {namedegree.ElementAt(i).Value} ");
                }


            }





        }
        }
    };
