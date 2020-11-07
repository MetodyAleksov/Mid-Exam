using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> deck = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Add")
                {
                    if (deck.Contains(command[1]))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                    else
                    {
                        deck.Add(command[1]);
                        Console.WriteLine("Card successfully bought");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (deck.Contains(command[1]))
                    {
                        deck.Remove(command[1]);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < deck.Count)
                    {
                        deck.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string card = command[2];
                    if (index >= 0 && index < deck.Count)
                    {
                        if (deck.Contains(card))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {
                            deck.Insert(index, card);
                            Console.WriteLine("Card successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", deck));
            //100/100
        }
    }
}
