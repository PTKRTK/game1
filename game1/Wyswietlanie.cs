using System;
using System.Collections.Generic;
using System.Text;

namespace game1
{
    class Wyswietlanie
    {
        //szerokosc okna
        private static int sz_o=100;
        //wysokosc okna
        private static int w_o=100;
        public void Wyswietl(int[,] wyswietlanie)
        { 
            tlo(wyswietlanie);
            Wypisz(wyswietlanie);

        
        }

        private static void tlo(int[,] wyswietlanie)
        {
            for (int i = 0; i < w_o ; i++)
            {
                for (int j = 0; j < sz_o; j++)
                {
                    wyswietlanie[i, j] = j;
                }
            }
        }

        private static void Wypisz(int[,] wyswietlanie)
        {
          for (int i = 0; i < w_o ; i++)
            {
                for (int j = 0; j < sz_o; j++)
                {
                    Console.Write(wyswietlanie[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
