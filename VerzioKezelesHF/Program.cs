using System;

namespace VerzioKezelesHF
{
    class Program
    {
        static double beolvas(int szam)
        {
            int atlag = 0;
            for (int i = 0; i < szam; i++)
            {
                int outside;
                bool exit = false;
                do
                {
                    Console.Write("\nAdjon meg egy egesz szamot: ");
                    exit = Int32.TryParse(Console.ReadLine(), out outside);
                } while (!exit);
                atlag += outside;
            }
            Console.WriteLine("\nA(z) " + szam + " db szam atlaga: " + (double)atlag / szam);
            return atlag / szam;

        }
        static void Main(string[] args)
        {
            beolvas(10);
        }
    }
}
