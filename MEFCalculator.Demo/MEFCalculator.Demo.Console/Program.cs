using System;

namespace MEFCalculator.Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.ForegroundColor = ConsoleColor.Gray;
                new Calculator();

                System.Console.WriteLine("Press any key to cles application.");
                System.Console.ReadKey();
            }
            catch (Exception ex)
            {
                ConsoleHelper.Error(ex);

                System.Console.WriteLine("Press any key to cles application.");
                System.Console.ReadKey();
            }
        }
    }
}
