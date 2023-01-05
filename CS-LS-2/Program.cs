using System;


namespace CS_LS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kan = 0;
            int karmir = 0;
            int dex = 0;

            string[] yashik = { "Karmir", "Kanach", "Dexin", "Kanach", "Karmir", "Karmir", "Kanach", "Dexin", "Kanach" };

            for (int i = 0; i < yashik.Length; i++)
            {
                switch (yashik[i])
                {
                    case "Kanach":
                        kan++;
                        break;

                    case "Dexin":
                        dex++;
                        break;

                    case "Karmir":
                        karmir++;
                        break;
                }
            };

            Console.WriteLine("===========================================");
            Console.WriteLine("Kanach: " + kan);
            Console.WriteLine("Karmir: " + karmir);
            Console.WriteLine("Dexin: " + dex);
            Console.WriteLine("===========================================");
        
        }
    }
}
