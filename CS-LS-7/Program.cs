using System;

namespace CS_LS_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("asdasdasd");
            //    i++;
            //}
            //while (i < 6);

            //bool cerek = false;

            //int jam;


            //Console.WriteLine("========================");
            //Console.WriteLine("Greq jam");
            //Console.WriteLine("========================");

            //jam = int.Parse(Console.ReadLine());

            //if(jam >= 07 && jam <= 20)
            //{
            //    if(jam < 25)
            //    {
            //        cerek = true;
            //        if (cerek == true)
            //        {
            //            Console.WriteLine("========================");
            //            Console.WriteLine("Cerek");
            //        }
            //        else
            //        {
            //            Console.WriteLine("========================");
            //            Console.WriteLine("Gisher");
            //        }

            //    } 
            //    else {
            //        Console.WriteLine("ASDASDASD");
            //    }
            //}


            //string gushan;
            //do
            //{
            //    Console.WriteLine("=====================");
            //    Console.WriteLine("Gushaleq anun@");
            //    Console.WriteLine("=====================");
            //    gushan = Console.ReadLine();
            //}
            //while (gushan != "Suren");

            //Console.Clear();

            //Console.WriteLine("===================================");
            //Console.WriteLine("Suren");
            //Console.WriteLine("===================================");
            //Console.WriteLine("Shnorhavor du gushakeciq anun@");
            //Console.WriteLine("===================================");

            int tiv;
            do
            {
                Console.WriteLine("=====================");
                Console.WriteLine("Greq tiv");
                Console.WriteLine("=====================");
                tiv = int.Parse(Console.ReadLine());
            }
            while (tiv % 2 == 1);
                        
            Console.WriteLine("=====================");
            Console.WriteLine("Tisht e");
            Console.WriteLine("=====================");
        }
    }
}
