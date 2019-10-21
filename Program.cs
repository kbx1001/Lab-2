using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Detail Room Generator");

            //Initialize

            string userDecision;
            double length;
            double width;
            double height;

            do
            {
                Console.WriteLine("Please enter the width of your room");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length of your room");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of your room");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine("The area of the room is " + length * width);

                Console.WriteLine("The perimeter of the room is " + (length + width));

                Console.WriteLine("The volume of the room is " + (length * width * height));

                Console.WriteLine("Would you like to enter the measurments of another room (y/n)?");
                userDecision = Console.ReadLine();
                while (userDecision.ToLower() != "y" && userDecision.ToLower() != "n")
                {
                    Console.WriteLine("Please try again, you can use (y/n)");
                    Console.ReadLine();
                }
            } while (userDecision.ToLower() == "y");
            Console.WriteLine("Goodbye!");
        }

    }
}

