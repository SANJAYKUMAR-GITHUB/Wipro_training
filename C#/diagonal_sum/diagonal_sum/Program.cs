// using System;

// namespace program
// {
//     class diagonla
//     {
//         static void Main(string[] args)
//         {
//         //     int[ , ] matr = {
//         //         {1, 2, 3},
//         //         {3, 4, 5},
//         //         {5, 6, 7}
//         //     };

//         //     int len = matr.GetLength(0);
//         //  Console.WriteLine(len);

            

//             Console.WriteLine("enter the size of matrix: ");
//             int size = int.Parse(Console.ReadLine());

//             int [,] matrix = new int[size, size];
            

//             Console.WriteLine("Enter the matrix elements:");

//             for(int i =0;i<size;i++)
//             {
//                 for (int j=0;j<size;j++)
//                 {
//                     Console.Write($"Element [{i},{j}]: ");
//                     matrix[i, j] = int.Parse(Console.ReadLine());
//                 }
//             }

//             int sum1= 0;

//             for (int i = 0;i<size;i++)
//             {
//                 Console.WriteLine("Matr[i,i]: "+matrix[i,i]);
//                 sum1 +=matrix[i,i];
//             }

//             Console.WriteLine("Sum of principal diagonal elements: "+sum1);


//         }
//     }
    
// }