using System;

namespace _2._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                    
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            
        }
        
    }
}
