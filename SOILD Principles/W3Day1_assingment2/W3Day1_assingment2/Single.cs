//using System;

//public sealed class Logger
//{
//    private static Logger _instance;
//    private static readonly object _lock = new object();

//    // Private constructor to prevent instantiation
//    private Logger() { }

//    public static Logger Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new Logger();
//                }
//                return _instance;
//            }
//        }
//    }

//    public void Log(string message)
//    {
//        Console.WriteLine($"Log: {message}");
//    }
//}


//class Single
//{
//    static void Main()
//    {
//        Logger logger1 = Logger.Instance;
//        Logger logger2 = Logger.Instance;

//        logger1.Log("Application started.");
//        logger2.Log("User logged in.");

//        Console.WriteLine($"logger1 and logger2 are the same instance: {logger1 == logger2}");
//    }
//}
