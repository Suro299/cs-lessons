using System;

namespace CS_LS_9
{
    class Program
    {
        public string num1;
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
          
            int tiv = poxtiv.func(number);

            Console.WriteLine(tiv);

        }
        
    }

    class poxtiv
    {
        public static int func(string number)
        {

            int num2;

            num2 = int.Parse(number);

            if (num2 % 2 == 0)
            {
                Console.WriteLine("=============");
                Console.WriteLine(num2 + "- Tiv@ zuyq e");
                Console.WriteLine("=============");
            } else
            {
                Console.WriteLine("=============");
                Console.WriteLine( num2 + "- Tive@ kent e");
                Console.WriteLine("=============");
            }
            
            return num2;

        }
    }
}
