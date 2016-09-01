using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_0901_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt hela namn?");
            string namn;
            namn = Console.ReadLine();
            

            Console.WriteLine("Ditt namn " + namn + " innehåller " + namn.Length + " tecken");

            string nynamn = namn.Replace(" ", "");
            Console.WriteLine("Ditt namn innehåller utan mellanslag " + nynamn.Length + " tecken" );

            string förnamn;
            förnamn = namn.Split(' ')[0];
            Console.WriteLine("Ditt förnamn är " + förnamn + " och innehåller " + förnamn.Length + " tecken");

            string efternamn;
            efternamn = namn.Split(' ')[1];
            Console.WriteLine("Ditt efternamn är " + efternamn + " och innehåller " + efternamn.Length + " tecken");

            Console.WriteLine(efternamn + " " + förnamn);

           
            foreach (char letter in förnamn)
                            {
                Console.WriteLine("---->" + letter);
                            }
            
                        foreach (char letter in efternamn)
                            {
                Console.WriteLine("------>" + letter);
                            }

            string namnLower = namn.ToLower();
            

            char[] reversed = namnLower.ToCharArray();
            Array.Reverse(reversed);
            new string(reversed);

            Console.WriteLine(reversed);



        }





    }




        }
    

