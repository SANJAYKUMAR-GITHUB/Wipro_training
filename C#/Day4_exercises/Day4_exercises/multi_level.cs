////using System;

////namespace Day4_exercises
////{
////    class vehicle
////    {
////        public int number;
////        public string name;
////        public string make;

////        public void displaydetails()
////        {
////            Console.WriteLine("number of vehicle: " + number);
////            Console.WriteLine("name of vehicle: " + name);
////            Console.WriteLine("make of vehicle " + make);
////        }
////    }
////    class car : vehicle 
////    {
////        public void makeofcar()
////        {
////            Console.WriteLine("make of car is 2024");
////        }
////    }
////    class bike : car //multi level inheritance
////    {
////        public void makeofbile()
////        {
////            Console.WriteLine("make of bike is: 2023");
////        }
////    }
////    internal class single_level_inheritance
////    {
////        static void Main(string[] args)
////        {
////            bike b1 = new bike();
////            b1.number = 89;
////            b1.name = "n160";
////            b1.make = "bajaj";

////            b1.makeofcar();
////            b1.displaydetails();
////            b1.makeofbile();
////        }
////    }
////}

//using System;

//namespace Day4_exercises
//{
//    class animal
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

//    class dog : animal
//    {
//        public void makeofdog()
//        {
//            Console.WriteLine("The dog is boww boww");
//        }
//    }
//    class frog : dog
//    {
//        public void makeoffrog()
//        {
//            Console.WriteLine("The frog is jumping");
//        }
//    }
//    class lion : frog
//    {
//        public void makeoflion()
//        {
//            Console.WriteLine("the lion is roaring");
//            }
//    }
//    internal class single_level_inheritance
//    {
//        static void Main(string[] args)
//        {

//            lion l1 = new lion();
//            l1.makeofdog();
//            l1.age = 20;
//            l1.name = "dog_animals";
//            l1.country = "india";
//            l1.displaydetails();


//            l1.makeoffrog();
//            l1.age = 30;
//            l1.name = "jumping";
//            l1.country = "brazil";
//            l1.displaydetails();


//            l1.makeoflion();
//            l1.age = 22;
//            l1.name = "fighting";
//            l1.country = "africa";
//            l1.displaydetails();





//        }
//}
//}


