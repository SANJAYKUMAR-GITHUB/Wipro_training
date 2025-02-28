//using System;

//namespace Day2_exercies2
//{
//    internal class prime_or_not
//    {
//        static void Main(string[] args)
//        {
//            prime_or_not obj = new prime_or_not();
//            string result = obj.num(7);  // Call the method to check if 5 is prime
//            Console.WriteLine(result);   // Print the result
//        }

//        public string num(int a)
//        {
//            // A prime number is greater than 1 and divisible only by 1 and itself
//            if (a <= 1)
//                return "Not prime";  // Numbers less than or equal to 1 are not prime

//            // Check for factors from 2 to the square root of 'a'
//            for (int i = 2; i < a; i++)
//            {
//                if (a % i == 0)
//                    return "Not prime";  // Found a divisor, not prime
//            }

//            // If no divisors were found, the number is prime
//            return "Prime";
//        }
//    }
//}
