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


            string lowcase = namn.ToLower();


            for (int i = 0; i < namn.Length; i++)
                            {
                                if (i % 2 != 0)
            Console.Write(lowcase[i].ToString().ToUpper());
                                else
            Console.Write(lowcase[i]);
                            }


            Console.WriteLine("skriv in ditt namn igen:");
            string namn2;
            namn2 = Console.ReadLine();
            
            for (int i = 0; i < namn2.Length; i++)
            {
                switch (namn2[i])
                {
                    case ('a'):
                        Console.Write("4");
                        break;
                
                    case ('e'):
                        Console.Write("3");
                        break;
           
                    case ('i'):
                        Console.Write("1");
                        break;
            
                        break;
                    case ('o'):
                        Console.Write("0");
                        break;
                
                    case ('s'):
                        Console.Write("$");
                        break;
                    case ('t'):
                        Console.Write("7");
                        break;
               
                    default:
                        Console.Write(namn2[i]);
                        break;
                }



                }



            }





    }




        }
    

