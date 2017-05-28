using System;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Numberton numberton = new Numberton();

            Jay jay = new Jay();
            SilentBob silentBob = new SilentBob();

            numberton.NewNumber += jay.FetchNewNumber;
            numberton.NewNumber += silentBob.FetchNewNumber;

            int genNum = 0;
            while (genNum <= 0)
            {
                Console.WriteLine("Введите челое число генераций > 0 :");
                int.TryParse(Console.ReadLine(), out genNum);
            }

            for (int i = 0; i < genNum; i++)
            {
                    numberton.Generate();
            }

            if (jay.Score > silentBob.Score)
                Console.WriteLine($"Победил Jay со счетом {jay.Score} - {silentBob.Score}");

            else if (silentBob.Score > jay.Score)
                Console.WriteLine($"Победил SilentBob со счетом {silentBob.Score} - {jay.Score}");

            else
                Console.WriteLine("DRAW");
        }
    }
}
