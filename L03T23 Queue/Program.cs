using System;

namespace Method
{

    class Queue
    {
        List<string> customers = new List<string>();
        // method declaration
        public void GoToQueue(string name)
        {
            customers.Add(name);
            Console.WriteLine("On the queue now "+customers.Count +" customers");
            foreach (string i in customers)
            {
                Console.WriteLine(i);
            }
            
        }
        public void ExitQueue()
        {

             Console.WriteLine("In the queue " + customers.Count +" customers");
            foreach (string i in customers)
            {
                Console.WriteLine(i);
            }
        }
        public void Length(int len)
        {
            Console.WriteLine(len);
        }

        static void Main(string[] args)
        {
            // create class object 
            Queue q1 = new Queue();
            bool t = true;
            while (t)
            {
                Console.WriteLine("Give the name of the customer: ");
                string name = Console.ReadLine();
                Console.WriteLine(name);
                if (name == "")
                {
                    q1.ExitQueue();
                    break;
                }
                else
                {
                    q1.GoToQueue(name);
                }



                //call method 


            }

        }
    }
}