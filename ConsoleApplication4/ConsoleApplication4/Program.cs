using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //tester att skapa ett objekt av klassen car

            car c = new car();

            c.color = "red";

            Console.WriteLine("bilens färg är {0}", c.color);

            car d;

            d = c;

            d.color = "blue";

            Console.WriteLine("bilens färg är {0}", c.color);
            Console.WriteLine("bilens färg är {0}", d.color);

            int i=10;
            int j;
            j = i;
            j = 20;

            Console.WriteLine("i={0} och j={1}",i,j);

            theclass myCustomer = new theclass();

            myCustomer.firstName = "Kalle";
            myCustomer.lastName = "Anka";

            Console.WriteLine(myCustomer.fullName());

        }
    }

    public class car
    {
        public string registrationNumber { get; set; }

        public string make { get; set; }

        public string model { get; set; }

        public string color { get; set; }
    }
}
