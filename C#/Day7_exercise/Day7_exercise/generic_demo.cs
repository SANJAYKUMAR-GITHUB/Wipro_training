//using System;


//public static class GenericCalculator
//{
//    public static T Add<T>(T a, T b)
//    {
//        return (dynamic)a + (dynamic)b;
//    }

//    public static T Subtract<T>(T a, T b)
//    {
//        return (dynamic)a - (dynamic)b;
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        var intResultAdd = GenericCalculator.Add(5, 10);
//        var intResultSubtract = GenericCalculator.Subtract(10, 5);

//        var doubleResultAdd = GenericCalculator.Add(5.5, 10.3);
//        var dounleResultSubtract = GenericCalculator.Subtract(108, 8.8);

//        var floatResultAdd = GenericCalculator.Add(5.5f, 10.3f);
//        var floatResultSubtract = GenericCalculator.Subtract(6.5f, 2.6f);

//        Console.WriteLine($"Int add: {intResultAdd}");
//        Console.WriteLine($"Int sub: {intResultSubtract}\n");

//        Console.WriteLine($"Double add: {doubleResultAdd}");
//        Console.WriteLine($"Double sub: {dounleResultSubtract}\n");

//        Console.WriteLine($"Float add: {floatResultAdd}");
//        Console.WriteLine($"Float sub: {floatResultSubtract}"); 
//    }
//}