using System;

namespace MilesDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string userInput = Console.ReadLine();
            int miles = int.Parse(userInput);
            Console.WriteLine("How many gallons of gas have you used?");
            string userInput2 = Console.ReadLine();
            int gallon = int.Parse(userInput2);
            double milesPerGallon;
            milesPerGallon = (miles / gallon);
            Console.WriteLine("You have used " + milesPerGallon + " miles per gallon.");
            Console.ReadLine();
        }
    }
}
