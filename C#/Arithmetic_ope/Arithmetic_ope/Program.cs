using System;

namespace Arithmetic_ope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int nums2;
            int result;

            Console.WriteLine("enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            nums2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add is: " + (num1 + nums2));
            Console.WriteLine("sub is: " + (num1 - nums2));
            Console.WriteLine("mul is: " + (num1 * nums2));
            Console.WriteLine("div is: " + (num1 / nums2));
            Console.WriteLine("mod is: " + (num1 % nums2));

            Console.ReadLine();
        }
    }
}
