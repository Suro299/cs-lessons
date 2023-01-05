using System;
using System.Collections.Generic;

namespace CS_TEST_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ashx> Ashxlist = new List<ashx>();

            bool emstug = false;

            for (int i = 0; i < 2; i++ )
            {

                ashx newashx = new ashx();

                Console.WriteLine("=======================================");
                Console.WriteLine("Greq ashxatoxi Anun ev Azganun@");
                Console.WriteLine("=======================================");
                newashx.nameSurname = Console.ReadLine();

                Console.WriteLine("=======================================");
                Console.WriteLine("Greq ashxatoxi hascen");
                Console.WriteLine("=======================================");
                newashx.hasce = Console.ReadLine();

               
                while (!emstug)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Greq ashxatoxi Email-@");
                    Console.WriteLine("=======================================");
                    newashx.email = Console.ReadLine();
                    if (newashx.email.Contains("@"))
                    {
                        emstug = true;
                    }
                }

                Console.WriteLine("=======================================");
                Console.WriteLine("Greq ashxatoxi Heraxosahamar@");
                Console.WriteLine("=======================================");
                newashx.herham = int.Parse(Console.ReadLine());

                Console.WriteLine("=======================================");
                Console.WriteLine("Greq ashxatoxi uzat ashxatavard@ (senc te nenc dzer uzelov chi)");
                Console.WriteLine("=======================================");
                newashx.ashxatavardz = int.Parse(Console.ReadLine());

                Ashxlist.Add(newashx);

            }

            int pul2;
            Console.WriteLine("=============================================================================================================================");
            Console.WriteLine("Ete uzum ek pntrel ev tpel ashxatoxi tvyalner@ greq 1 ete uzum ek jnjel ashxatoxin greq 2 isk ete uzum ek poxel ashatavardz@ greq 3");
            Console.WriteLine("=============================================================================================================================");

            pul2 = int.Parse(Console.ReadLine());

            if(pul2 == 1)
            {
                string harcashxan1;
                Console.WriteLine("=======================================");
                Console.WriteLine("greq ashxatoxi anun@ ev azganun@");
                Console.WriteLine("=======================================");
                harcashxan1 = Console.ReadLine();

                foreach (ashx item in Ashxlist)
                {
                      if(harcashxan1 == item.nameSurname || item.nameSurname.Contains(harcashxan1))
                    {
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Anun ev Azganun: " + item.nameSurname + "\n" + "Hasce: " + item.hasce + "\n" + "Her hamar" + item.herham + "\n" + "Email: "  + item.email + "\n" + "Ashxatavardz: " + item.ashxatavardz);
                        Console.WriteLine("=======================================");
                    }
                };



            } else if (pul2 == 2)
            {

                string harcashxan1;
                Console.WriteLine("=======================================");
                Console.WriteLine("greq ashxatoxi anun@ ev azganun@");
                Console.WriteLine("=======================================");
                harcashxan1 = Console.ReadLine();

                foreach (ashx item in Ashxlist)
                {
                    if (harcashxan1 == item.nameSurname || item.nameSurname.Contains(harcashxan1)) 
                    {
                        Ashxlist.Remove(item);
                       
                        break;
                    }

                };

                foreach (ashx item in Ashxlist)
                {
                   
                   Console.WriteLine("=======================================");
                   Console.WriteLine("Anun ev Azganun: " + item.nameSurname + "\n" + "Hasce: " + item.hasce + "\n" + "Her hamar" + item.herham + "\n" + "Email: " + item.email + "\n" + "Ashxatavardz: " + item.ashxatavardz);
                   Console.WriteLine("=======================================");
                    
                };


            } else if (pul2 == 3)
            {
                string harcashxan1;
                Console.WriteLine("=======================================");
                Console.WriteLine("greq ashxatoxi anun@ ev azganun@");
                Console.WriteLine("=======================================");
                harcashxan1 = Console.ReadLine();

                foreach (ashx item in Ashxlist)
                {
                    if (harcashxan1 == item.nameSurname || item.nameSurname.Contains(harcashxan1))
                    {
                        Console.WriteLine("=======================================");
                        Console.WriteLine(item.nameSurname + " Ashxatavardz@: " + item.ashxatavardz);
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Greq no ashxatavardz@ " + item.nameSurname + " Ashxatoxi hamar");
                        item.ashxatavardz = int.Parse(Console.ReadLine());
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Anun ev Azganun: " + item.nameSurname + "\n" + "Hasce: " + item.hasce + "\n" + "Her hamar" + item.herham + "\n" + "Email: " + item.email + "\n" + "Ashxatavardz: " + item.ashxatavardz);
                        Console.WriteLine("=======================================");
                    }
                 
                };
            }
        }
    }

    class ashx
    {
        public string nameSurname;
        public string hasce;
        public string email;
        public int herham;
        public int ashxatavardz;
    }
}
