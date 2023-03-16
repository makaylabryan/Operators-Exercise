﻿using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            {
                if (a == 17 && b == 4) ;
                {
                    Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

                    Console.WriteLine("What is the radius of your circle?");
                    var radius = double.Parse(Console.ReadLine());

                    Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
                }
            }
        }
        public static double AreaOfCircle(double radius)
        {
                var area = Math.PI * Math.Pow(radius, 2);
                return area;
        }
    }
}
