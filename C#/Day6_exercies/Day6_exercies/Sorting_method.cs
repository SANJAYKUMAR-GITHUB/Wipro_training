//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 5, 2, 9, 1, 5, 6 };
//        Console.WriteLine("Original array:");
//        PrintArray(numbers);

//        BubbleSort(numbers);

//        Console.WriteLine("Sorted array:");
//        PrintArray(numbers);
//    }

//    static void BubbleSort(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    // Swap array[j] and array[j + 1]
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//        Console.WriteLine();
//    }
//}
using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Implement exception handling
        // Complete the code below to demonstrate various aspects of exception handling
        if (args.Length > 0)
        {
            try
            {
                switch (args[0])
                {
                    case "IndexOutOfRangeException":
                        int[] num = new int[4];
                        Console.WriteLine(num[10]);
                        // Trigger IndexOutOfRangeException
                        break;
                    case "DivideByZeroException":
                        // Trigger DivideByZeroException
                        int a = 6;
                        int b = 0;
                        Console.WriteLine(a / b);
                        break;
                    case "FileNotFoundException":
                        // Trigger FileNotFoundException
                        File.ReadAllText("hello.txt");
                        break;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range error: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero error: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found error: " + ex.Message);
            }
        }
    }
}