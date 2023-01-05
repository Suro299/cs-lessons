using System;

namespace CS_LS_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string anun = "";
            string ser = "";
            int tariq = 0;




            Console.WriteLine("===================================");
            Console.WriteLine("Greq dzer Anun@");
            Console.WriteLine("===================================");
            anun = Anun();

            if (anun == "")
            {
                Console.WriteLine("Cheq gre dzer anun@");

            }
            else
            {
                Console.WriteLine("===================================");
                Console.WriteLine("Greq dzer tariq@ (petq e lini 18 ic bardzr)");
                Console.WriteLine("===================================");
                tariq = Tariq();
                if (tariq < 18)
                {
                    Console.WriteLine("Tarqiq@ petq e lini 18 ic bardzr");
                } else {
                    Console.WriteLine("===================================");
                    Console.WriteLine("Greq dzer ser@ (Txa, Axjik, txa, axjik)");
                    Console.WriteLine("===================================");
                    ser = Ser();

                    Console.WriteLine("===================================");
                    Console.WriteLine(" ");

                    Console.WriteLine("TVYALNER");

                    Console.WriteLine("===================================");
                    Console.WriteLine("Anun: " + anun);
                    Console.WriteLine("Ser: " + ser);
                    Console.WriteLine("Tariq: " + tariq);
                    Console.WriteLine("===================================");


                }

            }

            //=============================================================
            static string Anun()
            {
                string anun = "Cheq gre dzer anun@";
                anun = Console.ReadLine();

                return anun;

            }


            //----------------------------------------
            static int Tariq()
            {
                int tariq;
                tariq = int.Parse(Console.ReadLine());

                return tariq;
            }


            //---------------------------------------
            static string Ser()
            {
                string ser;
                ser = Console.ReadLine();
                return ser;
            }
        }
    }
}
