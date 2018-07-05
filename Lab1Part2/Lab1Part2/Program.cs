using System;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean unverified = true;
            DateTime firstDate = DateTime.Parse("1/1/2000");
            DateTime secondDate = DateTime.Parse("1/1/2001");
            TimeSpan diff;
            Console.WriteLine("Welcome to the date checker!");

            //Looping and try/catch to handle invalid datetime inputs
            while (unverified)
            {
                try
                {
                    Console.WriteLine("Enter the first date.");
                    firstDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second date.");
                    secondDate = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid date. Try again.");
                    continue;
                }
                unverified = false;
            }

            //Calculates the difference between the two dates and displays it
            diff = firstDate.Subtract(secondDate).Duration();
            Console.WriteLine("The difference between the two dates is:");
            Console.WriteLine(diff.Days + " Days, " + diff.Hours + " Hours, and " + diff.Minutes + " Minutes");
            Console.WriteLine("Press enter to close...");
            Console.Read();
        }
    }
}
