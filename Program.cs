using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_8_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(random.Next(0, 41));
            }

            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Largest: " + numbers.Max());
            Console.WriteLine("Smallest: " + numbers.Min());

            Console.WriteLine();

            Console.WriteLine("All numbers:");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);

                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Numbers with words");

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 10)
                {
                    Console.Write("Ten ");
                }
                else if (numbers[i] == 20)
                {
                    Console.Write("Twenty ");
                }
                else if (numbers[i] == 30)
                {
                    Console.Write("Thrity ");
                }
                else if (numbers[i] == 40)
                {
                    Console.Write("Forty ");
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //Part 3
        }
    }
}
