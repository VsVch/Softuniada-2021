using System;
using System.Collections.Generic;

namespace _1._Easter_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            List<int> result = new List<int>();
                
                for (int i = firstNumber; i <= secondNumber; i++)
                {

                    if ((i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i!=1) || i == 2 || i == 3 || i == 5 || i == 7 )
                    {
                        sum++;

                    result.Add(i);

                    }

                }
            Console.WriteLine(string.Join(" ", result));
           
            Console.WriteLine($"The total number of prime numbers between {firstNumber} to {secondNumber} is {result.Count}");
            






        }

    }
}

