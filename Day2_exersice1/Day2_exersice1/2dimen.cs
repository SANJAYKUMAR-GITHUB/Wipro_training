//using System;

//namespace Day2_exersice1
//{
//    internal class _2dimen
//    {
//        static void Main(string[] args)
//        {
//            //int[,] arr = new int[2,2]
//            //{
//            //    {5,6},
//            //    {7,8},
//            //};

//            //Console.WriteLine("Double Dimensional array demo: ");
//            //for (int i=0;i<arr.GetLength(0); i++)
//            //{
//            //    for (int j=0;j<arr.GetLength(1);j++)
//            //    {
//            //        Console.WriteLine(arr[i,j]);
//            //    }
//            //}


//            Console.WriteLine("Enter the row len: ");
//            int row = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the col len: ");
//            int col = int.Parse(Console.ReadLine());

//            int[,] arr1 = new int[row, col];
//            int[,] arr2 = new int[row, col];

//            Console.WriteLine("Enter the element of array1: ");
//            for (int i = 0; i < row; i++)
//            {
//                for (int j = 0; j < col; j++)
//                {
//                    Console.WriteLine($"Element at [{i},{j}]: ");
//                    arr1[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            Console.WriteLine("Enter the element of array2: ");
//            for (int i = 0; i < row; i++)
//            {
//                for (int j = 0; j < col; j++)
//                {
//                    Console.WriteLine($"Enter at [{i}, {j}]: ");
//                    arr2[i, j] = int.Parse(Console.ReadLine());
//                }
//            }


//            int[,] sumarray = new int[row, col];

//            for (int i = 0; i < row; i++)
//            {
//                for (int j = 0; j < col; j++)
//                {
//                    sumarray[i, j] = arr1[i, j] + arr2[i, j];
//                }
//            }

//            Console.WriteLine("\nAddition of arrays:");
//            for (int i = 0; i < row; i++)
//            {
//                for (int j = 0; j < col; j++)
//                {
//                    Console.Write(sumarray[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
