//using System;

//namespace A
//{
//    public class class1
//    {
//        public void method1()
//        {
//            //factorial
//            int fac = int.Parse(Console.ReadLine());
//            int result = 1;
//            for (int i = 1; i <= fac; i++)
//            {
//                result *= i;
//            }
//            Console.WriteLine(result);


//        }
//    }
//}


//namespace B
//{
//    public class Class2
//    {
//        public void Method2()
//        {
//            //prime
//            int result = 0;
//            int num = int.Parse(Console.ReadLine());
//            if (num <= 1)
//                Console.WriteLine("Not a prime");
//            else
//            {
//                for (int i = 2; i < num; i++)
//                {
//                    if (num % i == 0)
//                    {
//                        Console.WriteLine("Not a prime");
//                        result = 1;
//                        break;
//                    }

//                }
//            }
//            if (result == 0)
//                Console.WriteLine("Prime");
//        }
//    }
//}


//namespace D
//{
//    public class myclass
//    {
//        static void Main(string[] args)
//        {
//            A.class1 obj1 = new A.class1();
//            obj1.method1();
//            B.Class2 obj2 = new B.Class2();
//            obj2.Method2();
//        }
//    }
//}
////using System;

////namespace A
////{
////    public class Class1
////    {
////        public void function1()
////        {
////            Console.WriteLine("class1 name--A namespcae----function1");
////        }
////    }
////}

////namespace B
////{
////    public class Class2
////    {
////        public void function2()
////        {
////            Console.WriteLine("class2 ---- B namespcae-----function2");

////        }
////    }
////}


////namespace C
////{
////    public class Class3
////    {
////        public void fucntion3()
////        {
////            Console.WriteLine("Class2------C namespcae----function3");
////        }
////    }
////}

////namespace D
////{
////    public class namespace_demo
////    {
////        public void main(string[] args)
////        {
////            A.Class1 obj1 = new A.Class1();
////            obj1.function1();

////            B.Class2 obj2 = new B.Class2();
////            obj2.function2();

////            C.Class3 obj3 = new C.Class3();
////            obj3.fucntion3();
////        }
////    }
////}
