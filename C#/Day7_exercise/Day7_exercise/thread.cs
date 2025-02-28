//using System;
//using System.Threading;


//namespace Day7_exercise
//{
//   public  class thread
//    {

//        //static method one
//        public static void thrd1()
//        {
//            for (int t = 0;t<=10;t++)
//            {
//                Console.WriteLine("Therad1 is :{0}", t);
//                //When the value of t is equal to
//                //5 then this mehod sleeps for 5 seconds and
//                //after 5 sec it resumes its working

//                if (t==5)
//                {
//                    //Thread
//                    Thread.Sleep(5000);
//                }
//            }

//        }

//        public static void thrd2()
//        {
//            for (int t = 0; t <= 10; t++)
//            {
//                Console.WriteLine("Therad2 is :{0}", t);

//                if (t == 5)
//                {
//                    Thread.Sleep(5000);
//                }
//            }

//        }

//        static void Main(string[] args)
//        {
//            thread.thrd1();
//            thread.thrd2();
//        }
//    }
//}


