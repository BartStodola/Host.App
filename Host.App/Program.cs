using System;
using Calc;
using Logger;


namespace Host.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ILogger log = new Logger.Logger();
            log.Info("hello world.");

            ICalc calc = new Calc.Calc();
            var r = calc.Sub(1, -2);
            log.Warn($"result less than zero: {r}");

            Console.WriteLine("press any key!");
            Console.ReadLine();
        }
    }
}
