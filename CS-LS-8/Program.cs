using System;
using System.Collections.Generic;

namespace CS_LS_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string ser1;
            List<usanox> Uslist = new List<usanox>();

            for (int i = 0; i < 2; i++)
            {
                usanox newus = new usanox();

                Console.WriteLine("=======================");
                Console.WriteLine("Greq usanoxi anun@");
                Console.WriteLine("=======================");
                newus.anun = Console.ReadLine();

                Console.WriteLine("=======================");
                Console.WriteLine("Greq usanoxi azganun@");
                Console.WriteLine("=======================");
                newus.azganun = Console.ReadLine();

                Console.WriteLine("=======================");
                Console.WriteLine("Greq usanoxi tariq@");
                Console.WriteLine("=======================");
                newus.tariq = float.Parse(Console.ReadLine());

                Console.WriteLine("=======================");
                Console.WriteLine("Greq usanoxi ser@");
                Console.WriteLine("=======================");

                ser1 = Console.ReadLine();
                Console.WriteLine("=======================");



                if (ser1 == "Txa" || ser1 == "txa")
                {
                    newus.ser = true;
                }
                else if (ser1 == "Axjik" || ser1 == "axjik")
                {
                    newus.ser = false;
                }

                Uslist.Add(newus);
               
            }

            string sr;
            foreach (usanox item in Uslist)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=========================================");
                Console.ResetColor();

                if(item.ser == true)
                {
                    sr = "Txa";
                } else if (item.ser == false)
                {
                    sr = "Axjik";
                } else
                {
                    sr = "Sxal ek grel ser@";
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Anun: " + item.anun + "\n" + "Azganun: " + item.azganun + "\n" + "Tariq: " + item.tariq + "\n" + "Ser: " + sr);
                Console.ResetColor();
               

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=========================================");
                Console.ResetColor();

               

            }





        }
    }

    class usanox
    {
        public string anun;
        public string azganun;
        public float tariq;
        public bool ser;


    }
}
