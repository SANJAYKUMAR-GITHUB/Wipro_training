using System;

namespace A
{
    public class Class1
    {
        public void function1()
        {
            Console.WriteLine("class1 name--A namespcae----function1");
        }
    }
}

namespace B
{
    public class Class2
    {
        public void function2()
        {
            Console.WriteLine("class2 ---- B namespcae-----function2");

        }
    }
}


namespace C
{
    public class Class3
    {
        public void fucntion3()
        {
            Console.WriteLine("Class2------C namespcae----function3");
        }
    }
}

namespace D
{
    public class namespace_demo
    {
        public void main(string[] args)
        {
            A.Class1 obj1 = new A.Class1();
            obj1.function1();

            B.Class2 obj2 = new B.Class2();
            obj2.function2();

            C.Class3 obj3 = new C.Class3();
            obj3.fucntion3();
        }
    }
}
