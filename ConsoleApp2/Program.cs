using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11;
            int counter = 0;
            int ost;
            int[] array_of_numbers = new int[100];
            while (number > 0)
            {
                ost = number % 2;
                number /= 2;
                array_of_numbers[counter] = ost;
                counter += 1;
            }
            for (int i = 0; i < array_of_numbers.Length; i++)
            {
                Console.Write(array_of_numbers[i]);
            }
        }
    }
}
