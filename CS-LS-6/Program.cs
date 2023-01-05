using System;

namespace CS_LS_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 0;
            int a2 = 1;
     
            for(int i = 0; i < 40; i++)
            {
                int temp = a1;
                a1 = a2;
                a2 = a1 + temp;

                Console.WriteLine(a2);
                
                
            }
            

         




        }
     
    }
}
