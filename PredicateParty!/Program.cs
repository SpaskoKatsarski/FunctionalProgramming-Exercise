using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArgs[0]; //Double or Remove
                string criteria = cmdArgs[1]; //StartsWith, EndsWith or Length
                string arg = cmdArgs[2]; //letter or number (length)

                if (action == "Double")
                {
                    if (criteria == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].StartsWith(arg))
                            {
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (criteria == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].EndsWith(arg))
                            {
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (criteria == "Length")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].Length == int.Parse(arg))
                            {
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }
                    }
                }
                else if (action == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            string guest = guests[i];

                            if (guest.StartsWith(arg))
                            {
                                guests.Remove(guest);
                                i--;
                            }
                        }
                    }
                    else if (criteria == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            string guest = guests[i];

                            if (guest.EndsWith(arg))
                            {
                                guests.Remove(guest);
                                i--;
                            }
                        }
                    }
                    else if (criteria == "Length")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            string guest = guests[i];

                            if (guest.Length == int.Parse(arg))
                            {
                                guests.Remove(guest);

                                i--;
                            }
                        }
                    }
                }
            }

            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
