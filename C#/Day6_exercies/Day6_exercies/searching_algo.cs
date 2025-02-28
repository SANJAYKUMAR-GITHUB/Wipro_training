//using System;
//class searching_algo
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 3, 8, 2, 1, 4, 5, 6, 7 };

//            int target = 5;

//            int index = LinearSearch(numbers, target);

//            if (index != -1)
//            {
//                Console.WriteLine($"Element found at inded{index}");

//            }
//            else
//            {
//                Console.WriteLine("Element not found");

//            }
//        }


//        static internal LinearSearch(int[] array, int target)
//        {

//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] == target)
//                {
//                    return array[i];
//                }
//                return -1;
//            }
//        }


//using System;

//class program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
//        int target = 9;


//        int index = BinarySearch(numbers, target);

//        if (index !=-1)
//        {
//            Console.WriteLine($"Element found at index {index}:");

//        }
//        else
//        {
//            Console.WriteLine("Elemeent not found");
//        }
//    }

//    static int BinarySearch(int[] array, int target)
//    {
//        int left = 0;
//        int right = array.Length - 1;

//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;

//            if (array[mid] == target)
//            {
//                return mid;
//            }
//            if (array[mid] < target)
//            {
//                left = mid + 1;
//            }
//            else
//            {
//                right = mid - 1;
//            }
//        }

//        return -1; // Element not found
//    }
//}