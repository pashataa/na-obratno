using System;

namespace na_obratno
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse); 
        }
    }
}
