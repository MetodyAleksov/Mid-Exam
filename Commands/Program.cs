using System;
using System.Collections.Generic;
using System.Linq;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "remove")
                {
                    strings.RemoveRange(0, int.Parse(command[1]));
                }
                else
                {
                    List<string> backup = new List<string>();
                    for (int i = int.Parse(command[2]); i < int.Parse(command[2]) + int.Parse(command[4]); i++)
                    {
                        backup.Add(strings[i]);
                    }
                    if (command[0] == "reverse")
                    {
                        backup.Reverse();
                    }
                    else if (command[0] == "sort")
                    {
                        backup.Sort();
                    }
                    int counter = 0;
                    for (int i = int.Parse(command[2]); i < int.Parse(command[2]) + int.Parse(command[4]); i++)
                    {
                        strings[i] = backup[counter];
                        counter++;
                    }
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(", ", strings));
            //100/100
        }
    }
}
