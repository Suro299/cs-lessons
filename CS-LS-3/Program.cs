using System;
using System.Collections.Generic;

namespace CS_LS_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tver = { 123, 441, 23, 1234, -100, 4556, -1233, -211, 333 };

            //foreach (int item in tver)
            //{
            //    if (item < 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //List<int> Tver = new List<int>();
            //Tver.Add(10);
            //Tver.Add(110);
            //Tver.Add(1023);
            //Tver.Add(1044);
            //Tver.Add(11230);
            //Tver.Add(10677);


            //foreach (int num in Tver)
            //{
            //    Console.WriteLine(num);
            //}

            //int qan = 0;
            //List<string> Anunner = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    qan++;

            //    Console.WriteLine("===========================");
            //    Console.WriteLine("Greq Bar Hamar: " + qan);
            //    Console.WriteLine("===========================");

            //    Anunner.Add(Console.ReadLine());
            //}
            //qan = 0;
            //foreach (string item in Anunner)
            //{
            //    qan++;
            //    Console.WriteLine(" "); 
            //    Console.WriteLine("Bar Hamar " + qan + ": " + item);
            //}

            int qan = 0;

            List<string> obshi = new List<string>();
            List<string> Karmir = new List<string>();
            List<string> Dexin = new List<string>();
            List<string> Kanach = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                qan++;

                Console.WriteLine("===========================");
                Console.WriteLine("Greq xdnzori guyn hamar: " + qan);
                Console.WriteLine("===========================");

                obshi.Add(Console.ReadLine());
            }
        
            foreach (string item in obshi)
            {
                if (item == "Karmir")
                {
                    Karmir.Add("Karmir");
                }
                else if (item == "Kanach")
                {
                    Kanach.Add("Kanach");
                } else if (item == "Dexin")
                {
                    Dexin.Add("Dexin");
                }       
            }

            Console.WriteLine("Karmir: " + Karmir.Count);
            Console.WriteLine("Kanach: " + Kanach.Count);
            Console.WriteLine("Dexin: " + Dexin.Count);
        }
    }
}
