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
            Kirajzoló();
            Console.ReadKey();
        }

        static void Feltöltés(char[,] pálya)
        {
            for (int i = 0; i < pálya.GetLength(0); i++)
            {
                for (int j = 0; j < pálya.GetLength(1); j++)
                {
                    pálya[i, j] = '_';
                }
            }

            Random rnd = new Random();
            int sor, oszlop;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    sor = rnd.Next(10);
                    oszlop = rnd.Next(10);

                } while (pálya[sor, oszlop] == 'B');
                pálya[sor, oszlop] = 'B';
            }
        }

        static void Kirajzoló()
        {
            
        }               
    }
}
