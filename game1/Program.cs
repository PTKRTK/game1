using Microsoft.VisualBasic;
using System;

namespace game1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] wyswietlanie = new char[100, 100];
            Wyswietlanie wyswietlanie_ = new Wyswietlanie();
            wyswietlanie_.Wyswietl(wyswietlanie);
        }

        
    }
}
