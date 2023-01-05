//using System;
//using System.Collections.Generic;

//namespace CS_LS_11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            smartfon[] mysmartphons = new smartfon[3];

//            for (int i = 0; i < 3; i++)
//            {

//                if (i == 0)
//                {
//                    mysmartphons[0] = new ios();
//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Gret Smartphni hamar anvanum(ios)");
//                    Console.WriteLine("===================================");
//                    mysmartphons[0].anvanum = Console.ReadLine();

//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Gret Smartphni hamar guyn(ios)");
//                    Console.WriteLine("===================================");
//                    mysmartphons[0].guyn = Console.ReadLine();

//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Gret Smartphni hamar Arjeq(ios)");
//                    Console.WriteLine("===================================");
//                    mysmartphons[0].arjeq = int.Parse(Console.ReadLine());
//                } else if (i == 1)
//                {
//                    mysmartphons[i] = new ios();
//                    Console.WriteLine("===========================================");
//                    Console.WriteLine("Gret Smartphni hamar anvanum(Android 1)");
//                    Console.WriteLine("===========================================");
//                    mysmartphons[i].anvanum = Console.ReadLine();

//                    Console.WriteLine("===========================================");
//                    Console.WriteLine("Gret Smartphni hamar guyn(Android 1)");
//                    Console.WriteLine("===========================================");
//                    mysmartphons[i].guyn = Console.ReadLine();

//                    Console.WriteLine("===========================================");
//                    Console.WriteLine("Gret Smartphni hamar Arjeq(Android 1)");
//                    Console.WriteLine("===========================================");
//                    mysmartphons[i].arjeq = int.Parse(Console.ReadLine());
//                } else if (i == 2)
//                {
//                    mysmartphons[i] = new ios();
//                    Console.WriteLine("===========================================");
//                    Console.WriteLine("Gret Smartphni hamar anvanum(Android 2)");
//                    Console.WriteLine("===========================================");
//                    mysmartphons[i].anvanum = Console.ReadLine();

//                    Console.WriteLine("===========================================");
//                    Console.WriteLine("Gret Smartphni hamar guyn(Android 2)");
//                    Console.WriteLine("===========================================");
//                    mysmartphons[i].guyn = Console.ReadLine();

//                    Console.WriteLine("===========================================");
//                    Console.WriteLine("Gret Smartphni hamar Arjeq(Android 2)");
//                    Console.WriteLine("===========================================");
//                }
//            }

//            ((ios)mysmartphons[0]).Ios();
//        }
//    }

//    class smartfon
//    {
//        public string anvanum;
//        public string guyn;
//        public int arjeq;
//    }

//    class ios : smartfon
//    {
//        public void Ios()
//        {
//            Console.WriteLine("es ios em");
//            return;

//        }

//    }

//    class android : smartfon
//    {
//        public void Andr()
//        {
//            Console.WriteLine("es androidn em");
//            return;
//        }

//    }

//}

//using System;

//namespace CS_LS_11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Mard[] normard = new Mard[3];

//            for (int i = 0; i < 3; i++)
//            {

//                if (i == 0)
//                {

//                    normard[0] = new Tnoren();
//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Grq anun tnoreni hamar");
//                    Console.WriteLine("===================================");
//                    normard[0].anun = Console.ReadLine();




//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq azganun tnoreni hamar");
//                    Console.WriteLine("===================================");
//                    normard[0].azganun = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq ser tnoreni hamar");
//                    Console.WriteLine("===================================");
//                    normard[0].ser = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq tariq tnoreni hamar");
//                    Console.WriteLine("===================================");
//                    normard[0].tariq = int.Parse(Console.ReadLine());
//                    Console.Clear();
//                }
//                else if (i == 1)
//                {

//                    normard[i] = new Ashxatakic();
//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Grq anun ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].anun = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq azganun ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].azganun = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq ser ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].ser = Console.ReadLine();


//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.BackgroundColor = ConsoleColor.Green;
//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq tariq ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].tariq = int.Parse(Console.ReadLine());
//                    Console.ResetColor();

//                    Console.Clear();
//                }
//                else if (i == 2)
//                {

//                    normard[i] = new Ashxatakic();
//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Grq anun v hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].anun = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq azganun ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].azganun = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq ser ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].ser = Console.ReadLine();



//                    Console.WriteLine("===================================");
//                    Console.WriteLine("Greq tariq ashxatoxi hamar");
//                    Console.WriteLine("===================================");
//                    normard[i].tariq = int.Parse(Console.ReadLine());

//                    Console.Clear();
//                }
//            }

//            Console.WriteLine("==============================");
//            ((Tnoren)normard[0]).tnorenfunkcia();
//            Console.WriteLine(" ");
//            ((Ashxatakic)normard[1]).ashxatakicfunkcia();
//            Console.WriteLine(" ");
//            ((Ashxatakic)normard[2]).ashxatakicfunkcia();
//            Console.WriteLine("==============================");
//        }
//    }

//    class Mard
//    {
//        public string anun;
//        public string azganun;
//        public string ser;
//        public int tariq; 
//    }

//    class Tnoren : Mard
//    {
//        public void tnorenfunkcia()
//        {
//            Console.WriteLine("es tnoren em" + anun + " " + azganun);
//        }

//    }

//    class Ashxatakic : Mard
//    {
//        public void ashxatakicfunkcia()
//        {
//            Console.WriteLine("es ashxatakic em " + anun + " " + azganun);
//        }

//    }
//}






//===============================================TNAIN===============================================



using System;

namespace CS_LS_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook[] nornoutbook = new Notebook[2];

            for (int i = 0; i < 2; i++)
            {

                if (i == 0)
                {

                    nornoutbook[0] = new Dell();
                    Console.WriteLine("===================================");
                    Console.WriteLine("Grq notebook anvanum@ (Dell)");
                    Console.WriteLine("===================================");
                    nornoutbook[0].anvanum = Console.ReadLine();




                    Console.WriteLine("===================================");
                    Console.WriteLine("Greq notebooki guyn@ (Dell)");
                    Console.WriteLine("===================================");
                    nornoutbook[0].guyn = Console.ReadLine();


                    Console.WriteLine("===================================");
                    Console.WriteLine("Greq notebooki arjeq@ (Dell)");
                    Console.WriteLine("===================================");
                    nornoutbook[0].gin = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (i == 1)
                {

                    nornoutbook[i] = new HP();
                    Console.WriteLine("===================================");
                    Console.WriteLine("Grq notebook anvanum@ (HP)");
                    Console.WriteLine("===================================");
                    nornoutbook[i].anvanum = Console.ReadLine();




                    Console.WriteLine("===================================");
                    Console.WriteLine("Greq notebooki guyn@ (HP)");
                    Console.WriteLine("===================================");
                    nornoutbook[i].guyn = Console.ReadLine();


                    Console.WriteLine("===================================");
                    Console.WriteLine("Greq notebooki arjeq@ (HP)");
                    Console.WriteLine("===================================");
                    nornoutbook[i].gin = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                Console.Clear();
                
            }

            Console.WriteLine("==============================");
            ((Dell)nornoutbook[0]).DellFunction();
            Console.WriteLine(" ");
            ((HP)nornoutbook[1]).HPFunction();
            Console.WriteLine("==============================");
        }
    }

    class Notebook
    {
        public string anvanum;
        public string guyn;
        public int gin;
    }

    class Dell : Notebook
    {
        public void DellFunction()
        {
      
            Console.WriteLine("Dell");
            Console.WriteLine("===========================");
            Console.WriteLine("Anvanum@: " + anvanum);
            Console.WriteLine("Guyn: " + guyn);
            Console.WriteLine("Arjeq: " + gin);
            Console.WriteLine("===========================");

        }

    }

    class HP : Notebook
    {
        public void HPFunction()
        {
            Console.WriteLine(" ");
            Console.WriteLine("===========================");
            Console.WriteLine("HP");
            Console.WriteLine("===========================");
            Console.WriteLine("Anvanum@: " + anvanum);
            Console.WriteLine("Guyn: " + guyn);
            Console.WriteLine("Arjeq: " + gin);
          
        }

    }
}