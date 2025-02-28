// using System;

// class Userinput
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the size of the array: ");
//         int size=Convert.ToInt32(Console.ReadLine());

//         int[] arr=new int[size];//Declaring the array
//         Console.WriteLine("Enter the Elements: ");

//         for(int i=0;i<size;i++)
//         {
//             Console.Write($"Element {i}: ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         //Printing element using Foreach
//         Console.WriteLine("The element are: ");
//         Array.ForEach(arr,Console.WriteLine);

//     }
// }