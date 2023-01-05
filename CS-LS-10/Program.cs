using System;

namespace CS_LS_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Greq tiv");
            Console.WriteLine("=======================================");
            int num = int.Parse(Console.ReadLine());
            bool num2 = urishclas.func();

            if (num2 == true)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Duq greciq 10 ic met ev 20 ic poqr tiv");
                Console.WriteLine("=======================================");
            }
        }
    }

    class urishclas
    {
        public static bool func(int num)
        {
            bool esimich = false;
            while (!esimich)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Noric greq tiv");
                Console.WriteLine("=======================================");
                num = int.Parse(Console.ReadLine());
                if (num < 20 & num > 10)
                {
                    esimich = true;
                    return esimich;
                } 
            }
            return esimich;
        }
    }
}
