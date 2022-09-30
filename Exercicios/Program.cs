using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
                     
             int numAmount;

            Console.WriteLine("How many numbers do you wish to calculate?");
            numAmount = Convert.ToInt32(Console.ReadLine());
            int[] inputNumbers = new int[numAmount];

            //User input in each Array slot
            for(int i = 0; i < inputNumbers.Length; i++) 
            {
                Console.WriteLine("Write on the "+ i + " position");
                inputNumbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            
            //Write all Array numbers
            Console.WriteLine("These are the numbers you've input:");
            for(int i = 0; i < inputNumbers.Length; i++) 
            {
                Console.Write(inputNumbers[i] + " ");

            }






        }
    }
}
