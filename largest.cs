using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Largest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create the integer array and a var
            int[] myArr = {2,7,3,8,10,5};
            int largest = myArr[0];
            //loop through the array
            for (int i=0;i<myArr.Length;i++)
            {
                //when finds the biggest number, it assigns it to the var
                if(myArr[i] > largest)
                    largest = myArr[i];
            }
            
            Console.WriteLine(largest);
        }
    }
}