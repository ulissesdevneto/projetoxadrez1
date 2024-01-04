using System;
using System.Globalization;
using Tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + P);

            Console.ReadLine();

        }
    }
}
