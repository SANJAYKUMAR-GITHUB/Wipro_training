////BAD EXAMLE

////public class Rectangle
////{
////    public virtual int Width { get; set; }
////    public virtual int Height { get; set; }

////    public int GetArea() => Width * Height;
////}

////public class Square : Rectangle
////{
////    public override int Width
////    {
////        set { base.Width = base.Height = value; }
////    }

////    public override int Height
////    {
////        set { base.Width = base.Height = value; }
////    }
////}

//using System;
//using System.Collections.Generic;

//public interface IShape
//{
//    int GetArea();
//}

//public class Rectangle : IShape
//{
//    public int Width { get; set; }
//    public int Height { get; set; }

//    public int GetArea() => Width * Height;
//}

//public class Square : IShape
//{
//    public int Side { get; set; }

//    public int GetArea() => Side * Side;
//}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        List<IShape> shapes = new List<IShape>
//        {
//            new Rectangle { Width = 5, Height = 10 },
//            new Square { Side = 4 }
//        };

//        foreach (var shape in shapes)
//        {
//            Console.WriteLine($"Area: {shape.GetArea()}");
//        }
//    }
//}
