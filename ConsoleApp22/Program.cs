using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program służący do liczenia średniej arytmetycznej");

            float a;
            float sum = 0;
            int i = 0;

            do
            {
                Console.WriteLine("Podaj liczbę: ");
                a = float.Parse(Console.ReadLine());
                sum += a;
                i++;

            }
            while (a != 0);

            sum = (float)Math.Round(sum / (i-1), 2);
            Console.WriteLine($"Średnia arytmetyczna to: {sum}");
        }
    }
}
