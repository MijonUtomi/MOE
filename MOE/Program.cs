using System;

namespace MOE
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine();
        }

        public static int Add(int x, int y)
        {
            return (x + y);

        }
        public static decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }
        public static string Add(int x, int y, bool shouldAdd)
        {
            if (shouldAdd)
                x += y;

            string dollars = $"{x}dollar";
            if (x > 1)
                dollars += "s";
            return dollars;
        }
    }
}
