//Abstract classes :
//-more powerful compared to interfaces
//- abstract classes can have constructors, functions, variables
//- abstract class objects can not be created
//- derived class objects to access the features of abstract class
//-atleast 1 abstract method should be present in abstract class
//- abstract keyword is used for both abstract class and functions


//using System;


//namespace Day4_exercises
//{
//    class Class1 // polymorphism overloading (complie time)
//    {
//        public void add()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("additoion is: "+(a + b));
//        }
//        public void add(int a)
//        {
//            Console.WriteLine("Addition is: "+(a+a));
//        }
//        public void add(int a, int b)
//        {
//            Console.WriteLine("Addition is: "+(a+b));
//        }

//    }

//    class poly
//    {
//        static void Main(string[] args)
//        {
//            Class1 obj= new Class1();
//            obj.add();
//            obj.add(2);
//            obj.add(89, 90);
//        }
//    }
//}



//using System;


//namespace Day4_exercises
//{
//    class Class1
//    {
//        public void add()
//        {
//            int a = 10, b = 40;
//            Console.WriteLine("additoion is: " + (a + b));
//        }
//     }

//    class Class2 : Class1
//    {

//        public new void add()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("additoion is: " + (a + b));
//        }

//    }

//    class poly
//    {
//        static void Main(string[] args)
//        {
//            Class1 obj1= new Class1();
//            obj1.add();

//            Class2 obj2=new Class2();
//            obj2.add();
//        }
//    }
//}



using System;

namespace Day4_exercises
{
    class Class1
    {
        public abstract void welcome();

        public void display()
        {
            Console.WriteLine("display function is invoked");
        }

    }
    class us : Class1
    {
        public override void welcome()
        {
            Console.WriteLine("Welcome to our country");
        }
    }

    class poly
    {
        static void Main(string[] args)
        {
            
        }
    }
}