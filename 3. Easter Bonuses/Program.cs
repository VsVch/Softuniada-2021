using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Easter_Bonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> bonus = new List<int>();

            while (input != "stop")
            {
                string name = input;
                bonus = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

                double persomalBonus = 0;
                double allBonuses = 0;
                List<int> proiz = new List<int>();
                for (int i = 0; i < bonus.Count; i++)
                {

                    proiz[i] = bonus[i + 1] * bonus[i + 2] * bonus[i+3];
                    


                    Console.WriteLine(string.Join(" ", proiz));

                    persomalBonus += bonus[i];
                    allBonuses += persomalBonus;
                }
                


                //Console.WriteLine($"{name} has a bonus of {persomalBonus} lv.");
                //Console.WriteLine($"The amount of all bonuses is {allBonuses} lv.");
                input = Console.ReadLine();
            }
        }
    }
}
