using System;

namespace CounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counter App");
            Console.WriteLine("Enter in a number");
            int.TryParse(Console.ReadLine(), out int numberEntered);

            Console.WriteLine("Do you want to count Up or Down from that number? (Options: Up or Down):");
            string optionSelected = Console.ReadLine();

            if(optionSelected == "Up")
            {
                for (int i = 0; i <= numberEntered; i++)
                {

                    Console.WriteLine($"Counting Up: {i}");
                }
            } 
            else if (optionSelected == "down")
            {
                for(int i = numberEntered; i >= 0; i--)
                {
                    Console.WriteLine($"Counting down: {i}");
                }

            }


        }
    }
}
