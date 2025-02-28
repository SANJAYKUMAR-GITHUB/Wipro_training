using System;

class dup
{
    static void Main(string[] args)
    {
        // string str1="aaaaaabbbbbccccc";

        string str1=Console.ReadLine();
        
        string result="";

        for (int i=0;i<str1.Length;i++)
        {
            if (result.Contains(str1[i])==false)
            result+=str1[i];
        }
        Console.WriteLine(result);

    }
}