using System;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number checker!");

            String firstNum, secondNum, repeatChoice;
            Boolean repeat = true;

            //This loop contains all user input and the outputs based on it
            while (repeat)
            {
                //User input
                Console.WriteLine("Please enter a positive whole number:");
                firstNum = Console.ReadLine();
                Console.WriteLine("Please enter another positive whole number, with the same amount of digits:");
                secondNum = Console.ReadLine();

                //Validates user input, restarts the loop if invalid
                if (!Validate(firstNum, secondNum)) continue;

                //Runs the sum checker and prints the result
                Console.WriteLine(SumCheck(firstNum, secondNum));

                //Asks user if they would like to run the program again
                while (true)
                {
                    Console.WriteLine("Run again? (Y/N)");
                    repeatChoice = Console.ReadLine();
                    if (repeatChoice == "Y" || repeatChoice == "y") break;
                    if (repeatChoice == "N" || repeatChoice == "n")
                    {
                        repeat = false;
                        break;
                    }
                    Console.WriteLine("Input invalid. Please enter Y for yes or N for no.");
                }

            }
            Console.WriteLine("Goodbye!");
        }

        //Method for validating user input
        public static Boolean Validate(String firstNum, String secondNum)
        {
            Boolean firstNumTest = int.TryParse(firstNum, out int firstResult);
            Boolean secondNumTest = int.TryParse(secondNum, out int secondResult);

            //Checks for inputs that aren't integers
            if (firstNumTest == false || secondNumTest == false)
            {
                Console.WriteLine("One of the entries was not a whole number. Please enter whole numbers.");
                return false;
            }

            //Checks for negative inputs
            if (firstResult < 0 || secondResult < 0)
            {
                Console.WriteLine("One of the entries was negative. Please enter a positive number.");
                return false;
            }

            //Checks for mismatching number lengths
            if (firstNum.Length != secondNum.Length)
            {
                Console.WriteLine("Numbers have different amounts of digits. Please enter two numbers of equal length.");
                return false;
            }
            return true;
        }

        //Method for testing whether the sum of each digit is the same
        public static Boolean SumCheck(String firstNum, String secondNum)
        {
            int numLength, firstDigit, secondDigit, total;

            numLength = firstNum.Length;
            firstDigit = int.Parse(firstNum.Substring(0, 1));
            secondDigit = int.Parse(secondNum.Substring(0, 1));
            total = firstDigit + secondDigit;

            for (int index = 1; index < numLength; index++)
            {
                firstDigit = int.Parse(firstNum.Substring(index, 1));
                secondDigit = int.Parse(secondNum.Substring(index, 1));
                if (total != firstDigit + secondDigit)
                    return false;
            }
            return true;
        }

    }
}
