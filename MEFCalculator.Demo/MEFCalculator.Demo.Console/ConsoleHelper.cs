using MEFCalculator.Demo.Base.Interface;
using System;
using System.Collections.Generic;

namespace MEFCalculator.Demo.Console
{
    public class ConsoleHelper
    {
        public static void Error(Exception ex)
        {
            Error(ex.ToString());
        }

        public static void Error(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void PrintCommands(IEnumerable<IOperationMetadata> commands)
        {
            System.Console.WriteLine("Welcome to the Calculator Application");
            System.Console.WriteLine("Available operators:");

            foreach(var command in commands)
            {
                System.Console.Write($"  ");
                Bold(command.Command);
                System.Console.WriteLine($" - {command.Description}, Operator type: {command.OperationType.ToString()}");
            }
        }

        private static void Bold(string text)
        {
            System.Console.BackgroundColor = ConsoleColor.White;
            System.Console.ForegroundColor = ConsoleColor.Black;
            System.Console.Write(text);
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
