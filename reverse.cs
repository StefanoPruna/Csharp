using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Reverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Please, enter a sentece to reverse: \n");
            string userString = Console.ReadLine();//saves the input in a new string var
            string last = string.Empty;//creates a new empty string
            for (int i = userString.Length - 1; i >= 0; i--)
                last += userString[i]; //loops through the string from the last letter and save it in the empty string

            Console.WriteLine(last);
        }
    }
}