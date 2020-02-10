using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aknakereso
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] pálya = new char[10, 10];

            Feltöltés(pálya);
            Kirajzoló(pálya);
            Console.ReadKey();
        }

        static void Feltöltés(char[,] pálya)
        {
            int sor, oszlop;
            for (sor = 1; sor < pálya.GetLength(0); sor++)
            {
                for (oszlop = 1; oszlop < pálya.GetLength(1); oszlop++)
                {
                    pálya[sor, oszlop] = '_';
                }
            }
            Console.Write("sor száma: ");
            int sorszám = int.Parse(Console.ReadLine());
            Console.Write("oszlop száma: ");
            int oszlopszám = int.Parse(Console.ReadLine());

            if (oszlopszám < 10 && sorszám < 10)
            {
                do
                {
                    sor = sorszám;
                    oszlop = oszlopszám;

                } while (pálya[sor, oszlop] == 'X');
                pálya[sor, oszlop] = 'X';
            }
        }

        static void Kirajzoló(char[,] pálya)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int sor = 1; sor < pálya.GetLength(0); sor++)
            {

                for (int oszlop = 1; oszlop < pálya.GetLength(1); oszlop++)
                {
                    Console.Write($"{pálya[sor, oszlop]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
