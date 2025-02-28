////using System;



////namespace Day6_exercies
////{
////    public static class DateTimeExtensions
////    {
////        public static bool IsWeekend(this DateTime date)
////        {
////            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
////        }
////    }

////    class Extension_demo
////    {
////        static void Main(string[] args)
////        {


////        DateTime today = DateTime.Now;

////        bool isWeekend = today.IsWeekend();

////        DateTime d1 = new DateTime(2025, 02, 03);

////        bool myvariable = d1.IsWeekend();
////    }
////}
////}

//using System;

//namespace demo

//{
//    class myclass
//    {
//        static void Main(string[] args)
//        {
//            //tuple creation
//            //var t = (123, "hello", true);
//            //var t1 = (11, 12, "aaa", "bjb");


//            ////accessing the Elements
//            //Console.WriteLine(t.Item1);
//            //Console.WriteLine(t.Item2);
//            //Console.WriteLine(t.Item3);

//            //Console.WriteLine(t1.Item1);
//            //Console.WriteLine(t1.Item2);
//            //Console.WriteLine(t1.Item3);
//            //Console.WriteLine(t1.Item4);


//            Tuple<string> t1 = new Tuple<string>("India");

//            Tuple<string, string, int> t2 = new Tuple<string, string, int>("C#", "python", 29);

//            Tuple<int, int, int, int, int, int, int, Tuple<int>> t3 =
//                new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));

//            Console.WriteLine(t1.Item1);
//            Console.WriteLine(t2.Item1);
//            Console.WriteLine(t3.Item1);
//            Console.WriteLine(t3.Item2);
//            Console.WriteLine(t3.Item3);
//            Console.WriteLine(t3.Item4);
//            Console.WriteLine(t3.Item5);
//            Console.WriteLine(t3.Item6);
//            Console.WriteLine(t3.Item7);
//        }
//    }

//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        string numberString = "25.0";
//        if (TryParseAndCalculateSquareRoot(numberString, out double number, out double squareRoot))
//        {
//            Console.WriteLine($"Parsed number: {number}");
//            Console.WriteLine($"Square root: {squareRoot}");
//        }
//        else
//        {
//            Console.WriteLine("Parsing or square root calculation failed.");
//        }
//    }

//    static bool TryParseAndCalculateSquareRoot(string input, out double number, out double squareRoot)
//    {
//        // Initialize out parameters
//        number = 0;
//        squareRoot = 0;

//        // Try to parse the string into a double
//        if (double.TryParse(input, out number))
//        {
//            // Calculate the square root if parsing is successful
//            if (number >= 0)
//            {
//                squareRoot = Math.Sqrt(number);
//                return true;
//            }
//        }

//        return false;
//    }
//}


//using System;

//class program
//{
//    static void Main(string[] args)
//    {
//        var person = ("Jhon", "Doe", 30);


//        //Deconstructor the tuple and discard the last name
//        var (firstname,_,age) = person;

//        Console.WriteLine($"First Name: {firstname}, Age: {age}");

//    }
//}