using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string userInput = Console.ReadLine();
            int length = int.Parse(userInput);
            Console.WriteLine("What is the width of the rectangle?");
            string userInput2 = Console.ReadLine();
            int width = int.Parse(userInput2);
            double area;
            area = (length * width);
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadLine();
        }
    }
}
