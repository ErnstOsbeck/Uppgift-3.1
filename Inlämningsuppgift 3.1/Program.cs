using System;

namespace uppgift_3._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            switch (ålder)
            {
                case < 16:
                    {
                        Console.WriteLine("Du är tyvärr för ung för att delta");
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("Du får vara med och delta!");
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("Du får vara med och delta!");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Du får vara med och delta!");
                        break;
                    }
                case 19:
                    {
                        Console.WriteLine("Du får vara med och delta!");
                        break;
                    }
                case > 19:
                    {
                        Console.WriteLine("Du är tyvärr för gammal för att delta");
                        break;
                    }
            }
        }
    }
}