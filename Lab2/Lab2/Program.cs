using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            bool repeat = true;
            int feet, inches;
            double length, width, height;

            while (repeat)
            {
                Console.Write("\nEnter Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine("\nArea: " + (length * width) + " square feet");
                Console.WriteLine("Volume: " + (length * width * height) + " cubic feet");
                Console.Write("Perimeter: ");
                DoubleToFeetInches(2 * length + 2 * width);

                repeat = CheckRepeat();
            }
            Console.WriteLine("\nGoodbye!");

            Console.Read();
        }

        static bool CheckRepeat()
        {
            String repeatSelection;

            Console.Write("Continue? (y/n): ");
            repeatSelection = Console.ReadLine();
            if (repeatSelection == "N" || repeatSelection == "n")
            {
                return false;
            }
            else if (repeatSelection != "Y" && repeatSelection != "y")
            {
                Console.WriteLine("Invalid selection. Input \"y\" for yes or \"n\" for no.");
                return CheckRepeat();
            }
            else return true;
        }

        static void DoubleToFeetInches(double feetAsDouble)
        {
            int feet = (int)Math.Floor(feetAsDouble);
            int inches = (int)(feetAsDouble - feet) * 12;
            Console.WriteLine(feet + "' " + inches + "\"");
        }
    }
}
