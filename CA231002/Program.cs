﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA231002
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mate";
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine($"{name}, do you like cats?");
            Console.Write(">>> ");
            string resp = Console.ReadLine();
            if (resp.ToLower().StartsWith("yes"))
            {
                Console.WriteLine("me too!");
            }
            else
            {
                Console.WriteLine("wrong answer.");
            }

            Console.WriteLine("What is your favourite color?");
            Console.Write(">>>> ");
            resp = Console.ReadLine();
            if (resp.ToLower().Contains("blue"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("This?");
            }
            else if(resp.ToLower().Contains("green"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("This?");
            }
            
            Console.ReadKey();
        }
    }
}
