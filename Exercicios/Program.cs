using System;
using System.Linq;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            int numAmount;
            int userOption;

            Console.WriteLine("How many numbers do you wish to calculate?");
            numAmount = Convert.ToInt32(Console.ReadLine());
            int[] inputNumbers = new int[numAmount];

            //User input in each Array slot
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine("Write on the " + i + " position");
                inputNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Write all Array numbers
            Console.WriteLine("These are the numbers you've input:");
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine(inputNumbers[i] + " ");
            }

            Console.WriteLine("Based on your input, please select one of the following options:");
            Console.WriteLine("1 - Average");
            Console.WriteLine("2 - Median");
            Console.WriteLine("3 - Moda");
            Console.WriteLine("4 - Maximum Value");
            Console.WriteLine("5 - Minimum Value");
            Console.WriteLine("6 - Quit");

            userOption = Convert.ToInt32(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    //Average
                    Console.WriteLine(inputNumbers.Average());

                    break;
                case 2:
                    //Median
                    Array.Sort(inputNumbers);

                    int size = inputNumbers.Length;
                    float median = size / 2;

                    //If the median is even
                    if (size % 2 == 0)
                    {
                        median = (inputNumbers[(size / 2) - 1] + inputNumbers[(size / 2)]) / 2.0f;
                        Console.WriteLine("The Median is: " + median);
                    }
                    //If the median is uneven
                    else
                    {
                        median = inputNumbers[(size / 2)];
                        Console.WriteLine("The Median is: " + median);
                    }
                    break;
                case 3:
                    //fazer moda
                    break;
                case 4:
                    //Max Value
                    Console.WriteLine("The maximum value is: " + inputNumbers.Max());
                    break;
                case 5:
                    //Min Value
                    Console.WriteLine("The minimum value is: " + inputNumbers.Min());
                    break;
                case 6:
                    //Quit
                    break;

            }




        }
    }
}
