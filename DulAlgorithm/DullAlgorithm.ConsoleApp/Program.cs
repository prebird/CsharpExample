using System;

namespace DullAlgorithm.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1] Input
            int[] data = { 1, 3, 5, 2, 4 };

            //[2] Process
            int[] numbers = DulAlgorithm.Algorithm.SelectionSort(data);

            //[3] Output
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
