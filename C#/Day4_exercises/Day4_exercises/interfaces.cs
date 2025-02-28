////interface:(in C# multilevel inharitance not support so we use interface for multileve)
// //two ways: implicit and explicit
// //easy for write aa program using interface

////===================================================================/////

////using System;

////namespace Day4_exercises
////{
////    interface ICalc //interface used in C# to use multilevel inheritance
////    {
////        void Addition();
////        void Subraction();

////    }
////    interface ICalc2 {

////        void Multiplication();
////    }
////    interface ICalc3
////    {
////        void Division();
////    }

////    class demo : ICalc,ICalc3
////    {
////        public void Addition()
////        {
////            int a = 10, b = 2;
////            Console.WriteLine("Addition result is: " + (a + b));
////        }

////        public void Subraction()
////        {
////            int a = 10, b = 2;
////            Console.WriteLine("Subration result is: " + (a - b));
////        }
////        public void Division()
////        {
////            int a = 10, b = 3;
////            Console.WriteLine("Division is: " + (a / b));
////        }
////    }

////    class demo1 : ICalc2
////    {
////        public void Multiplication()
////        {
////            int a = 10, b = 3;
////            Console.WriteLine("Multiplication result is:" + (a * b));
////    }
////    }

////    class main
////    {
////        static void Main(string[] args)
////        {
////            demo obj = new demo();

////            demo1 obj1 = new demo1();

////            obj.Addition();
////            obj.Subraction();
////            obj.Division();

////            obj1.Multiplication();
////        }
////    }
////}




//////Explicity way for interface mehtod
//using System;

//namespace Day4_exercises
//{
//    interface ICalc //interface used in C# to use multilevel inheritance
//    {
//        void Addition();
//        void Subraction();

//    }
//    interface ICalc2
//    {

//        void Multiplication();
//    }


//    class demo : ICalc, ICalc2
//    {
//        void ICalc.Addition()
//        {
//            int a = 10, b = 2;
//            Console.WriteLine("Addition result is: " + (a + b));
//        }

//        void ICalc.Subraction()
//        {
//            int a = 10, b = 2;
//            Console.WriteLine("Subration result is: " + (a - b));
//        }
//        void ICalc2.Multiplication()
//        {
//            int a = 10, b = 3;
//            Console.WriteLine("Division is: " + (a * b));
//        }
//    }



//    class main
//    {
//        static void Main(string[] args)
//        {

//            //demo obj = new demo(); //error implicit
//            //obj.Addition();//error

//            ICalc obj1 = new demo(); //explicit way 
//            obj1.Addition();
//            obj1.Subraction();

//            ICalc2 obj2= new demo();
//            obj2.Multiplication();
//        }
//    }
//}