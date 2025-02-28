// using System;

// class twodim
// {
//     static void Main(string[] args)
//     {
        
    
//     // int[ , ] two_dim=new int[2, 3];//Declaring the 2d array 6 elements (2 * 3).
//     //=================OR======================//
//     // int[ , ] two_dim = new int[2, 3]{ {1,2,3},{4,5,6}};
//     //==============================================================//
//     //Two-Dimensional Array initialization
//     int [ , ] two_dim = {
//         {1,2,3},
//         {4,5,6}
//     };
//      //accessing element in 2d array
//     // Console.WriteLine("elemtnt in [0, 0]: "+two_dim[0,0]+"\nElemtn in [0, 1]: "+two_dim[0,1]+"\nElement in [0, 2]"+two_dim[0,2]);

//     //accessing using for loop
//     // Console.WriteLine(two_dim.GetLength(0));//Getting the row length
//     // Console.WriteLine(two_dim.GetLength(1));//Getting the Col length
    
//     for(int i=0;i<two_dim.GetLength(0);i++)
//     {
//         for(int j=0;j<two_dim.GetLength(1);j++)
//         {
//                 Console.WriteLine($"Element in [{i},{j}] is: {two_dim[i, j]}");
//         }
//     }
// }
// }