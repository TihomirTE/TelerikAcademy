﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Anagrami
{
    public class Algogrami
    {
        public static void Main()
        {
            string input;
            string group = " ";
            var set = new HashSet<string>();

            do
            {
                input = Console.ReadLine();

                // Sort Alphabetically
                group = String.Concat(input.OrderBy(c => c));

                    set.Add(group); 
                
            } while (input != "-1");

            Console.WriteLine(set.Count - 1);
        }
    }
}
