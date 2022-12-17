

using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

namespace Rigister
{
    public interface Interface
    {
        void ShowTotal(double money, double money2);

    }

    public class PaidWithCard : Interface
    {

        void Interface.ShowTotal(double money, double money2)
        {
            double sum = 0;
            sum += money;
            Console.WriteLine("\nTotal money at bank account: " + sum);
        }
        public string type;
        public double Money { get; set; }
        public string card_Num;
        public DateTime date;


    }

    public class PaidWithCash : Interface
    {

        void Interface.ShowTotal(double money, double money2)
        {
            double sum = 0;
            sum = money + money2;
            Console.WriteLine("\nTotal money in cash: {0}", sum);
        }


        public string type;
        public double Money { get; set; }
        public int card_Num;
        public DateTime date;


    }

    class Program
    {

        static void Main(string[] args)
        {

            List<double> mylist = new List<double>();
            Interface obj = new PaidWithCash();
            PaidWithCash cash = new PaidWithCash();
            cash.type = "bill";
            cash.card_Num = 1;
            cash.Money = 100;

            mylist.Add(cash.Money);

            PaidWithCash cash2 = new PaidWithCash();
            cash2.type = "bill";
            cash2.card_Num = 2;
            cash2.Money = 50;
            mylist.Add(cash2.Money);// total list

            PaidWithCard card = new PaidWithCard();
            card.type = "charge";
            card.card_Num = "0001-0002";
            card.Money = 78.95;

            mylist.Add(card.Money);


            PaidWithCard card2 = new PaidWithCard();

            card2.type = "charge";
            card2.card_Num = "0003-0004";
            card2.Money = 45.65;

            mylist.Add(card2.Money);



            Console.WriteLine("\nTransaction to bank:  " + card.type + " from card  " + card.card_Num + " date " + card.date + " amount " + card.Money);
            Console.WriteLine("\nTransaction to bank:  " + card2.type + " from card  " + card2.card_Num + " date " + card2.date + " amount " + card2.Money);
            obj.ShowTotal(card.Money, card2.Money);
            Console.WriteLine("\nPaid with Cash:  " + cash.type + " number  " + cash.card_Num + " date " + cash.date + " amount " + cash.Money);
            Console.WriteLine("\nPaid with Cash:  " + cash2.type + " number  " + cash2.card_Num + " date " + cash2.date + " amount " + cash2.Money);
            obj.ShowTotal(cash.Money, cash2.Money);
            Console.WriteLine("\nTotal sales today : " + DateTime.Now + " is " + mylist.Sum());
            Console.WriteLine("\nProgram completed succesfullly. press any key to quit");
            Console.ReadLine();
        }
    }
}