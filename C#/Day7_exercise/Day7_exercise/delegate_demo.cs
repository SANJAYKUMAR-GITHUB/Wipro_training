
//using System;

//namespace Day7_exercise
//{
//    // Define delegate that accepts two integers as parameters
//    public delegate void delegate_calc(int a, int b);

//    class calc
//    {
//        // Methods for different operations
//        public void add(int a, int b)
//        {
//            Console.WriteLine("Sum: " + (a + b));
//        }

//        public void sub(int a, int b)
//        {
//            Console.WriteLine("Difference: " + (a - b));
//        }

//        public void mul(int a, int b)
//        {
//            Console.WriteLine("Product: " + (a * b));
//        }

//        public void div(int a, int b)
//        {
//            if (b != 0)
//                Console.WriteLine("Quotient: " + (a / (float)b));
//            else
//                Console.WriteLine("Division by zero is not allowed.");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create an instance of the calc class
//            calc calculator = new calc();

//            // Create delegate object or instance and point them to the methods
//            delegate_calc addDelegate = new delegate_calc(calculator.add);
//            delegate_calc subDelegate = new delegate_calc(calculator.sub);
//            delegate_calc mulDelegate = new delegate_calc(calculator.mul);
//            delegate_calc divDelegate = new delegate_calc(calculator.div);

//            // Invoke the methods via the delegates
//            addDelegate(10, 5);  // Should call the add method
//            subDelegate(10, 5);  // Should call the sub method
//            mulDelegate(10, 5);  // Should call the mul method
//            divDelegate(10, 5);  // Should call the div method

//            // Test division by zero
//            divDelegate(10, 0);  // Should show a division by zero error
//        }
//    }
//}



//using System;

//delegate int NumberChanger(int n);
//namespace DelegateAppl
//{

//    class TestDelegate
//    {
//        static int num = 10;

//        public static int AddNum(int p)
//        {
//            num += p;
//            return num;
//        }
//        public static int MultNum(int q)
//        {
//            num *= q;
//            return num;
//        }
//        public static int getNum()
//        {
//            return num;
//        }
//        static void Main(string[] args)
//        {
//            //create delegate instances
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);

//            //calling the methods using the delegate objects
//            nc1(25);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            nc2(5);
//            Console.WriteLine("Value of Num: {0}", getNum());

//        }
//    }
//}


//using action deligate//


//using System;

//class Program
//{
//    // Define a method that matches the signature of Action (no return value, parameters)
//    static void PrintMessage(string message)
//    {
//        Console.WriteLine(message);
//    }

//    static void Main()
//    {
//        // Creating an Action delegate that points to the PrintMessage method
//        Action<string> actionDelegate = PrintMessage;

//        // Using the delegate to call the method
//        actionDelegate("Hello from the Action delegate!");


//    }
//}




//============================================================================//
//using lambda delegate function////

//using System;

//class Program
//{
//    // Define a method that matches the signature of Action (no return value, parameters)
//    static void PrintMessage(string message)
//    {
//        Console.WriteLine(message);
//    }

//    static void Main()
//    {
//        Action<int, int> addNumbers = (a, b) =>
//        {
//            Console.WriteLine("Sum: " + (a + b));
//        };

//        // Calling the lambda through the delegate
//        addNumbers(5, 3);
//    }
//}


//=======================================================================================//

//func delegate demo//


//using System;

//class program
//{
//    static int Sum(int x, int y)
//    {
//        return x + y;
//    }
//    static void Main(string[] args)
//    {
//        Func<int, int, int> add = Sum;

//        int result = add(10, 10);
//        Console.WriteLine(result);
//    }
//}


//using System;

/////====================================================//////////////////////
//class myclass
//{
//    static bool IsUpperCase(string str)
//    {
//        return str.Equals(str.ToUpper());
//    }

//    static void Main(string[] args)
//    {
//        Predicate<string> a = IsUpperCase;
//        bool result = a("HELLO WORLD!!");
//        Console.WriteLine(result);
//    }
//}


//=============================================================================//

//using System;

//public delegate void Print(int value);

//class myclass 
//{
//    static void Main(string[] args)
//    {
//        Print print = delegate (int val)
//        {
//            Console.WriteLine(val);
//        };
//        print(100);
//    }
//}