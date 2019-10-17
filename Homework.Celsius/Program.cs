using System;

namespace Homework.Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string userChoice;
            double userAnswer;
            double fahrenheit;
            double celsius;

            Console.WriteLine("Choose Celsius or Fahrenheit C/F: ");
            userChoice = Console.ReadLine();

            if (userChoice.ToUpper() == "F")
            {
                Console.WriteLine("Write a degree in Fahrenheit: ");
                userAnswer = Double.Parse(Console.ReadLine());
                celsius = (userAnswer - 32) * 5 / 9;
                Console.WriteLine($"{userAnswer} is converted to celsius: {celsius} C.");
            }

            else if (userChoice.ToUpper() == "C")
            {
                Console.WriteLine("Write a degree in Celsius: ");
                userAnswer = Double.Parse(Console.ReadLine());
                fahrenheit = (userAnswer * 9 / 5) + 32;
                Console.WriteLine($"{userAnswer} is converted to fahrenheit: {fahrenheit} F.");
            }
            else
            {
                Console.WriteLine("Choose F (fahrenheit) or C (celsius)");
              
            }
            goto Start;
            
            Console.ReadLine();

        }
    }
}
