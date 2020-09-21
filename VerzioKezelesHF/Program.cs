using System;

namespace VerzioKezelesHF
{
    class Program
    {
        static double beolvas(int szam)
        {
            int[] tomb = new int[szam];
            int atlag = 0;
            for (int i = 0; i < szam; i++)
            {
                bool exit = false;
                do
                {
                    Console.Write("\nAdjon meg egy egesz szamot: ");
                    exit = Int32.TryParse(Console.ReadLine(), out tomb[i]);
                } while (!exit);
                atlag += tomb[i];
            }
            Console.WriteLine("\nA(z) " + szam + " db szam atlaga: " + (double)atlag / szam);
            MinMaxSearch(tomb);
            return atlag / szam;

        }

        static int[] MinMaxSearch(int[] tomb)
        {
            int[] indexs = new int[] { 0, 0 };
            for (int i = 1; i < tomb.Length; i++)
            {
                indexs[0] = tomb[i] < tomb[indexs[0]] ? i : indexs[0];
                indexs[1] = tomb[i] > tomb[indexs[1]] ? i : indexs[1];
            }
            Console.WriteLine("\nA tömb " + (indexs[0] + 1) + ". eleme a legkisebb: " + tomb[indexs[0]]);
            Console.WriteLine("\nA tömb " + (indexs[1] + 1) + ". eleme a legnagyobb: " + tomb[indexs[1]]);
            Console.WriteLine();
            return indexs;
        }
        static void Main(string[] args)
        {
            //2.Feladat + 4.Feladat
            beolvas(10);

            //3.Feladat + 4.Feladat
            bool exit = false;
            int szam;
            do
            {
                Console.Write("\nAdjon meg hany szam atlagat akarja: ");
                exit = Int32.TryParse(Console.ReadLine(), out szam);
            } while (!(exit && szam > 0));
            beolvas(szam);
        }
    }
}
