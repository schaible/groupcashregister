using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Register_rebuilt_with_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency[] cash = new Currency[6];

            for (int i = 0; i < 6; i++)
            {
                cash[i] = new Currency();
            }

            cash[0].Setup("hundred", "hundreds", 100.0m);
            cash[1].Setup("fifty", "fifties", 50.0m);
            cash[2].Setup("twenty", "twenties", 20.0m);
            cash[3].Setup("ten", "tens", 10.0m);
            cash[4].Setup("five", "fives", 5.0m);
            cash[5].Setup("one", "ones", 1.0m);



            Console.WriteLine("how much money was owed?");
            string answer1 = Console.ReadLine();
            decimal paid = decimal.Parse(answer1);

            Console.WriteLine("how much was paid");
            string answer2 = Console.ReadLine();
            decimal owed = decimal.Parse(answer2);

            decimal change = owed - paid;

            for (int i = 0; i < 6; i++)
            {
                while (change >= cash[i].value)
                {
                    change = change - cash[i].value;
                    cash[i].count++;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (cash[i].count > 1)
                {
                    Console.WriteLine("you will get " + cash[i].count + " " + cash[i].pluralName + " ");
                    cash[i].count = 0;
                }
                else if (cash[i].count == 1)
                {
                    Console.WriteLine("you will get " + cash[i].count + " " + cash[i].name + " ");
                    cash[i].count = 0;
                }
            }
            Console.ReadLine();
        }
        
        }
    class Currency
    {
        public int count;
        public string name;
        public string pluralName;
        public decimal value;

        public void Setup(string givenName, string givenpluralName, decimal givenValue)

        {
            name = givenName;
            pluralName = givenpluralName;
            value = givenValue;
            count = 0;

        }
    }

}


      
