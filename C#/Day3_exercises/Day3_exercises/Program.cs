////using System;


////namespace Day3_exercises
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            //static void method we can call directly
////            method1();

////            //for public void we need object(instance) for this
////            //method2(); --->>error

////            Program obj1 = new Program();

////            obj1.method2();

////        }
////        static void method1()
////        {
////            Console.WriteLine("Static void is invoked");

////        }
////        public void method2()
////        {
////            Console.WriteLine("Public void method is invoked");

////        }
////    }
////}


////using System;


////namespace Day3_exercises
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {


////            A obj1 = new A();// A is a different class name
////            A.method1();

////            obj1.method2();

////        }
////       }

////        class A { 
////        public static void method1()
////        {
////            Console.WriteLine("Static void is invoked");

////        }
////        public void method2()
////        {
////            Console.WriteLine("Public void method is invoked");

////        }
////    }
////}

////using System;


////namespace Day3_exercises
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {


////            A obj1 = new A();// A is a different class name
////            A.method1();

////            obj1.method2();

////        }
////    }

////    internal class A // making class as private
////    {
////        public static void method1()
////        {
////            Console.WriteLine("Static void is invoked");

////        }
////        public void method2()
////        {
////            Console.WriteLine("Public void method is invoked");

////        }
////    }
////}

//using System;


//namespace Day3_exercises
//{
//    internal class Program// it can only accessble in single namespace
//    {
//        static void Main(string[] args)
//        {


//            A obj1 = new A();// A is a different class name
//            A.method1();// not able to access the method in private

//            obj1.method2();

//        }
//    }

//    class A// it can accessbly outside in the different namespace
//    {
//        private void method1()
//        {
//            Console.WriteLine("Static void is invoked");

//        }
//        public void method2()
//        {
//            Console.WriteLine("Public void method is invoked");

//        }
//    }
//}

