using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            bool canContinue = true;

            while (canContinue)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(command[1]))
                        {
                            phonebook[command[1]] = command[2];
                        }
                        else
                        {
                            phonebook.Add(command[1], command[2]);
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {command[1]} does not exist.");
                        }
                        break;
                    case "END":
                        canContinue = false;
                        break;
                }
            }
        }
    }
}