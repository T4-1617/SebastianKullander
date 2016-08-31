using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            Console.WriteLine("skriv in ditt första tal;");

            int x;
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("skriv in ditt andra tal:");

            int y;
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange räknesätt:");

            int answer = 0;
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "+":
                answer = x + y;
                break;

                case "-":
                answer = x - y;
                break;

                case "/":
                answer = x / y;
                break;

                case "*":
                answer = x * y;
                break;

            }
            Console.WriteLine(answer);
            
            
                
            
          








        }
    }
}
