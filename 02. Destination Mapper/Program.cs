using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(={1}|\/{1})(?<town>[A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);
            int travelPoints = 0;
            string text = Console.ReadLine();
            List<string> destinations = new List<string>();

            MatchCollection match = regex.Matches(text);
            
            foreach (Match item in match)
            {
                destinations.Add(item.Groups[2].Value);
                travelPoints += item.Groups[2].Value.Length;
            }           
            Console.WriteLine($"Destinations: {string.Join(", ",destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}