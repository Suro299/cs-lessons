using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int qan = 0;
            string login = "Suren";
            string password = "123123";

            List<string> hyut = new List<string>();


            string l;
            string p;

            Console.WriteLine("Nermuteq Login@");

            l = Console.ReadLine();

            if (l == login)
            {
                Console.WriteLine("Nermuteq parol@");

                p = Console.ReadLine();


                if (p == password)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        qan++;
                        Console.WriteLine("Nermuteq nuyuti anun (" + qan + ")");
                        hyut.Add(Console.ReadLine());
                    }

                    Console.WriteLine("ete uzum ek nayel hyuter@ greq 1re uzum ek jnjel inch vor apranq greq 2");

                    string inch;
                    inch = Console.ReadLine();

                    if (inch == "1")
                    {
                        foreach (string item in hyut)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (inch == "2")
                    {
                        Console.WriteLine("Inchn eq uzum jnjel");
                        hyut.Remove(Console.ReadLine());
                        Console.WriteLine("=========================");
                        foreach (string item in hyut)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }

            }
        }


    }
}
