using System;
using System.IO;

namespace IntroToCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] values = (int[])Enum.GetValues(typeof(System.ConsoleColor));
            string[] names = Enum.GetNames(typeof(System.ConsoleColor));
            Console.WriteLine("Values in System.UriPartial Enum");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Names in System.UriPartial Enum");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
          
            Console.ReadLine();
        }


    }



}
