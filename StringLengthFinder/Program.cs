using System;

namespace stringlengthHelper
{
    public static class LengthHelper
    {
        public static int FindLength(string str)
        {
            int length = 0;
            foreach(var i in str)
            {
                length++;
            }
            return length;
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

