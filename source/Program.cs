using System;
using Draw.Extensions;

namespace Draw
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter character [O, X, Y, Z]: ");
            var input = Console.ReadKey();
            var choice = GetChoiceFromInput(input);
            
            Console.Write("\nEnter a non negative odd integer: ");
            var inputSize = Console.ReadLine();
            int.TryParse(inputSize, out var size);
            while (!size.IsValidSize())
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a non negative odd integer: ");
                int.TryParse(Console.ReadLine(), out size);
            }
            var drawer = new Drawer();
            drawer.Draw(choice, size);
        }

        private static string GetChoiceFromInput(ConsoleKeyInfo input)
        {
            var choice = "";
            while (string.IsNullOrWhiteSpace(choice))
            {
                switch (input.Key)
                {
                    case ConsoleKey.O:
                        choice = ConsoleKey.O.ToString();
                        break;
                    case ConsoleKey.X:
                        choice = ConsoleKey.X.ToString();
                        break;
                    case ConsoleKey.Y:
                        choice = ConsoleKey.Y.ToString();
                        break;
                    case ConsoleKey.Z:
                        choice = ConsoleKey.Z.ToString();
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice!");
                        Console.Write("Enter character [O, X, Y, Z]: ");
                        input = Console.ReadKey();
                        break;
                }
            }

            return choice;
        }
    }
}
