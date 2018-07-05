using System;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate, secondDate;
            TimeSpan diff;
            Console.WriteLine("Enter the first date.");
            firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second date.");
            secondDate = DateTime.Parse(Console.ReadLine());
            diff = firstDate.Subtract(secondDate).Duration();
            Console.WriteLine("The difference between the two dates is:");
            Console.WriteLine(diff.Days + " Days, " + diff.Hours + " Hours, and " + diff.Minutes + " Minutes");
            Console.Read();
        }
    }
}
