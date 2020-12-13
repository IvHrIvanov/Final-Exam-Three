using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            string stops = Console.ReadLine();

            string[] commands = Console.ReadLine().Split(":");

            while (commands[0] != "Travel")
            {
                string curCommand = commands[0];

                if (curCommand == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    string secondStop = commands[2];
                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, secondStop);               
                    }
                }
                else if (curCommand == "Remove Stop")
                {

                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);                       
                    }

                }
                else if (curCommand == "Switch")
                {
                    string oldStop = commands[1];
                    string newStop = commands[2];
                    if (stops.Contains(oldStop))
                    {
                        stops = stops.Replace(oldStop, newStop);
                        
                    }
                }

                Console.WriteLine(stops);
                commands = Console.ReadLine().Split(":");

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}