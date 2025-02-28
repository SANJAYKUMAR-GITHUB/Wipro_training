//using System;

//namespace Day4_exercises
//{
//    // Base class
//    class Animal
//    {
//        public int age;
//        public string name;
//        public string country;

//        public void displaydetails()
//        {
//            Console.WriteLine("Animal age is: " + age);
//            Console.WriteLine("Animal name is: " + name);
//            Console.WriteLine("Animal country is: " + country);
//        }
//    }

//    // Derived class: Dog inherits from Animal
//    class Dog : Animal
//    {
//        public void makeofdog()
//        {
//            Console.WriteLine("The dog is boww boww");
//        }
//    }

//    // Derived class: Frog inherits from Animal
//    class Frog : Animal
//    {
//        public void makeoffrog()
//        {
//            Console.WriteLine("The frog is jumping");
//        }
//    }

//    // Derived class: Lion inherits from Animal
//    class Lion : Animal
//    {
//        public void makeoflion()
//        {
//            Console.WriteLine("The lion is roaring");
//        }
//    }

//    internal class HierarchicalInheritance
//    {
//        static void Main(string[] args)
//        {
//            // Create an instance of Dog
//            Dog d1 = new Dog();
//            d1.age = 3;
//            d1.name = "Dog";
//            d1.country = "India";
//            d1.displaydetails();  // From Animal class
//            d1.makeofdog();       // Specific to Dog class

//            Console.WriteLine("\n");

//            // Create an instance of Frog
//            Frog f1 = new Frog();
//            f1.age = 5;
//            f1.name = "Frog";
//            f1.country = "Amazon";
//            f1.displaydetails();  // From Animal class
//            f1.makeoffrog();      // Specific to Frog class

//            Console.WriteLine("\n");

//            // Create an instance of Lion
//            Lion l1 = new Lion();
//            l1.age = 20;
//            l1.name = "Lion";
//            l1.country = "Africa";
//            l1.displaydetails();  // From Animal class
//            l1.makeoflion();      // Specific to Lion class
//        }
//    }
//}
