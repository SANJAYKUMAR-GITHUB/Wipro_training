//using System;

//public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }
//    }
//class main
//{
//    static void Main(string[] args)
//    {
//        List<Person> people = new List<Person>
//            {
//                new Person("Alice", 25),
//                new Person("bob",33),
//                new Person("acahl",33),
//                new Person("david",40)

//            };

//        var filteredPeople = people.Where(p => p.Age > 30);

//        var names = filteredPeople.Select(p => p.Name);

//        Console.WriteLine("People over 30:");

//        foreach(var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}


//class dog
//{
//    public string Name { get; set }
//    public int Age { get; set; }

//}

//class demo
//{
//    static void Main(string[] args)
//    {
//        List<dog> dogs = new List<dog>()
//        {
//            new dog { Name="Rex", Age=4 },
//            new dog {Name="sean", Age=0 },
//            new dog { Name="stacy",Age=3 }
//        };
//        var names = dogs.Select(X => X.Name);
//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//        Console.Read();
//    }
//}


