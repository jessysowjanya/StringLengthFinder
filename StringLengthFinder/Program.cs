using System;

namespace stringlengthHelper
{
    public static class LengthHelper
    {
        public static int FindLength(string str)
        {
            return str.Length;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            length = LengthHelper.FindLength(str);
            Console.WriteLine("length of the string is " + length);
        }
    }
}

