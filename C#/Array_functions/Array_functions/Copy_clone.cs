// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] original = { 1, 2, 3, 4, 5 };

//         int[] copy=  new int[original.Length];

//         Array.Copy(original, copy,original.Length);
//         Console.WriteLine("Printing Copy using foreach: ");
//         Array.ForEach(copy,Console.WriteLine);

//         //===============================================================//
//         int[] clone=(int[])original.Clone();
//         Console.WriteLine("Prinring the Clone using join: "+string.Join(" ,\t",clone));
        
//     }
// }