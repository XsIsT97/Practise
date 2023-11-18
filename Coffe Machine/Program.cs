using System;
using System.Collections.Generic;

namespace Fun_work22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> itemsLoaded = new Dictionary<string, int>();
            int wipesUsed = 0;

            Console.WriteLine("Welcome to the Coffee Machine Simulator!");
            Console.WriteLine("Enter the items to load into the machine (type 'Loaded' to start cleaning):");

            while (true)
            {
                string input = Console.ReadLine().Trim();

                if (input.ToLower() == "loaded")
                {
                    Console.WriteLine("Cleaning process initiated. Enter the number of wipes used (type 'Cleaned' to finish):");
                    break;
                }

                LoadItem(input, itemsLoaded);
            }

            while (true)
            {
                string input = Console.ReadLine().Trim();

                if (input.ToLower() == "cleaned")
                {
                    break;
                }

                if (int.TryParse(input, out int wipes))
                {
                    wipesUsed += wipes;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of wipes or type 'Cleaned' to finish.");
                }
            }

            Console.WriteLine("\nItems loaded into the machine:");
            foreach (var item in itemsLoaded)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine($"\nTotal wipes used for cleaning: {wipesUsed}");
        }

        static void LoadItem(string item, Dictionary<string, int> itemsLoaded)
        {
            if (itemsLoaded.ContainsKey(item))
            {
                itemsLoaded[item]++;
            }
            else
            {
                itemsLoaded[item] = 1;
            }
        }
    }
}
