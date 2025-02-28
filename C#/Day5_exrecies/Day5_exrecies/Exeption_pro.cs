//using System;

//using System.Collections.Generic;
//using System.Collections;



//namespace Day5_exrecies
//{
//    class Exeption_pro
//    {
//        static void Main(string[] args)
//        {
//            //Stack s1= new Stack();
//            //s1.Push(1);
//            //s1.Push(2);
//            //s1.Push(3);
//            //s1.Push(4);
//            //s1.Push(5);

//            //Console.WriteLine("stack element are: ");
//            //foreach (var item in s1)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            Stack s1 = new Stack();
//            s1.Push(1);
//            s1.Push('a');
//            s1.Push("bnglor");
//            s1.Push(4.899);
//            s1.Push(580809.9889);

//            Console.WriteLine("stack element are: ");
//            foreach (var item in s1)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("the delted element in stack is: "+s1.Pop());
//            Console.WriteLine("stack element are: ");
//            foreach (var item in s1)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("top most element in Stack: "+s1.Count);

//            //==================================//
//            Console.WriteLine("queue element are: ");
//            Queue q1 = new Queue();
//            q1.Enqueue(1);
//            q1.Enqueue(2);
//            q1.Enqueue(8099.2);
//            q1.Enqueue("jooklj");
//            q1.Enqueue('e');

//            foreach(var item in q1)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("The deque element is: "+q1.Dequeue());

//            //====================================///

//            ArrayList arr1= new ArrayList();
//            arr1.Add(1);
//            arr1.Add(2);
//            arr1.Add(3);
//            arr1.Add(4);

//            arr1.AddRange(arr1);

//            int[] myarray = new int[3] {10,20,30};
//            arr1.AddRange(myarray);

//            Console.WriteLine("The element in array are:");
//            foreach (var item in arr1)
//            {
//                Console.WriteLine(item);
//            }

//            arr1.RemoveRange(0, 3);
//            arr1.Remove(20);
//            arr1.RemoveAt(0);


//            ///==================


//            List<int> ls = new List<int>();
//            ls.Add(10);
//            ls.Add(20);
//            ls.Add(30);
//            ls.Add(40);

//            Console.WriteLine("The element in List are:");
//            foreach (var item in ls)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}


