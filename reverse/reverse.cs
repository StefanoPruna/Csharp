using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a sentece to reverse: \n");
            string userString = Console.ReadLine();
            string last = string.Empty;
            for (int i = userString.Length - 1; i >= 0; i--)
                last += userString[i];

            Console.WriteLine(last);
        }
    }
}
