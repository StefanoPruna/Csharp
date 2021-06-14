using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Asks for the three sides of the triangles
            Console.WriteLine("Please, enter the firt side of the triangle: \n");
            int firstSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the second side of the triangle: \n");
            int secondSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the third side of the triangle: \n");
            int thirdSide = Convert.ToInt32(Console.ReadLine());

            /*I have tried to handle the error in case the user doesn't input a number, 
            For example with if(int.TryParse(Console.ReadLine(), out firstSide)) in a while loop with a boolean var, but without success;*/

            //Console.WriteLine(firstSide + " " + secondSide + " " + thirdSide);
            //Checks what type of triangle is according to the sides input before
            if (firstSide != secondSide && secondSide != thirdSide)
                Console.WriteLine("The triangle is a Scalene triangle, all sides are different");
            else if(firstSide == secondSide && secondSide == thirdSide)
                Console.WriteLine("The triangle is an Equilateral Triagle, all three sides are equal");
            else if()
                Console.WriteLine("The triangle is an Isosceles triangle, two sides are equal");    
        }
    }
}