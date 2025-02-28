// using System;
// using System.Security.Principal;

// namespace jagged
// {
//     class Jagged
//     {
//         static void Main(string[] args)
//         {
//             // int[][] Jagg = new int[4][]; //C# Jagged Array Declaration

//             // set size of the array
//             // Jagg[0]=new int[4];
//             // Jagg[1]=new int[3];
//             // Jagg[2]=new int[3];
//             // Jagg[3]=new int[2];
        
        
//             //    Initializing Jagged Array Using the index number

//             // Jagg[0][0]=1;
//             // Jagg[0][1]=2;
//             // Jagg[0][2]=3;
//             // Jagg[0][3]=4;

//             // Jagg[1][0]=4;
//             // Jagg[1][1]=5;
//             // Jagg[1][2]=6;

//             // Jagg[2][0]=7;
//             // Jagg[2][1]=8;
//             // Jagg[2][2]=9;

//             // Jagg[3][0]=10;
//             // Jagg[3][1]=11;
            




//             // Initialize without setting size of array elements

//             // Jagg[0] = new int[]{1,2,3,4};
//             // Jagg[1] = new int[] {4,5,6};
//             // Jagg[2]=new int[] {7,8,9};
//             // Jagg[3]=new int[] {10,11};

//             // Initialize while declaring Jagged Array
//             int[][]JaggedArray = {
//                 new int[ ] {1,2,3,4},
//                 new int[ ] {4,5,6},
//                 new int[ ] {7,8,9},
//                 new int[ ] {10,11} 
//             };

           
//             Console.WriteLine("Length: "+JaggedArray.Length);
//         //Access the elment in array
//             for (int i = 0;i<JaggedArray.Length;i++)
//             {
//                 Console.Write($"Element in {i}: ");
                
//                 for ( int j =0;j<JaggedArray[i].Length;j++)
//                 {
//                     Console.Write(JaggedArray[i][j]+" ");
//                 }
//                 Console.WriteLine();
//             }

// //========================================================================================================//
//         //for adding each array in jagged array
//             for(int i = 0;i<JaggedArray.Length;i++)
//             {
//                 int sum=0;
//                 for(int j=0;j<JaggedArray[i].Length;j++)
//                 {
//                     sum += JaggedArray[i][j];
//                 }
//                 Console.WriteLine($"Sum of Element in {i} is: {sum}");
                
//             }
//         }

//     }
// }