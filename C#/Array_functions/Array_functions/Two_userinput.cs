// using System;
// using System.Drawing;
// using System.Transactions;

// class two_arr
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the size of row: ");
//         int row=Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the size of Col ");
//         int col=Convert.ToInt32(Console.ReadLine());

//         int[ , ] twoD=new int[row, col];

//         Console.WriteLine("Enter the elements: ");
        
//         //Getting input from user using for looop
//         for(int i =0;i<row;i++)
//         {
//             for(int j=0;j<col;j++)
//             {
//                 Console.Write($"Element at [{i}, {j}]: ");
//                 twoD[i, j]=Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         //=================================================================================//

//         Console.WriteLine("Print the values: ");
//         for(int i=0;i<row;i++)
//         {
//             for(int j=0;j<col;j++)
//             {
//                 Console.WriteLine($"Element in [{i}, {j}] is: {twoD[i,j]}");

//             }
//         }

//         Console.WriteLine("Print the values in matrix format : ");
//         for(int i=0;i<row;i++)
//         {
//             for(int j=0;j<col;j++)
//             {
//                 Console.Write(twoD[i, j]+" ");

//             }
//             Console.WriteLine();
//         }

//     }
// }