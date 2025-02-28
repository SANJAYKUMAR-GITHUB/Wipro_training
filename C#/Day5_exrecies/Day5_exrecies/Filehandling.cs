//using System;
//using System.IO;

//namespace Day5_exrecies
//{
//    class Filehandling
//    {
//        static void Main(string[] args)
//        {


//            FileInfo f1 = new FileInfo(@"C:\Users\SANJAYKUMAR K\Desktop\Wipro C#\Day5_exrecies\Day5_exrecies\Program.cs");
//            Console.WriteLine(f1.Name);
//            Console.WriteLine(f1.FullName);
//            Console.WriteLine(f1.Length);
//            Console.WriteLine(f1.DirectoryName);
//            Console.WriteLine(f1.CreationTime);
//            Console.WriteLine(f1.LastWriteTime);
//            Console.WriteLine(f1.Extension);


//            //===================================================

//            DriveInfo df = new DriveInfo("c:\\");
//            Console.WriteLine("\nSystem information:\n"+df.TotalSize);
//            Console.WriteLine(df.Name);
//            Console.WriteLine(df.AvailableFreeSpace);

//            //==================================================

//            DirectoryInfo diffo = new DirectoryInfo("C:\\Certificates");
//            Console.WriteLine("\nFolder information: \n"+diffo.FullName);
//            Console.WriteLine(diffo.Name);
//            Console.WriteLine(diffo.CreationTime);

//        }
//    }
//}
