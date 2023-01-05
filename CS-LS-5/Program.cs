using System;

namespace CS_LS_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = func1();
            Console.WriteLine(name);
        }

        static string func1()
        {
            Console.WriteLine("Greq dzer anun@");
            string name;
            name = Console.ReadLine();
            return name;

        }
    }
}
