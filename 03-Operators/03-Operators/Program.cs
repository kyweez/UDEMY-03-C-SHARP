using System;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine("=================================");

            var a1 = 1;
            var b1 = 2;
            var c1 = 3;
            Console.WriteLine(a1 + b1 * c1);
            Console.WriteLine("=================================");

            var a2 = 1;
            var b2 = 2;
            var c2 = 3;
            Console.WriteLine((a2 + b2) * c2);
            Console.WriteLine("=================================");

            var a3 = 1;
            var b3 = 2;
            Console.WriteLine(a3 > b3); //false
            Console.WriteLine(a3 == b3); //false
            Console.WriteLine(a3 != b3); //true
            Console.WriteLine(a3 < b3); //true
            Console.WriteLine(!(a3 != b3)); //false
            Console.WriteLine((a3 == b3) == false); //true
            Console.WriteLine("=================================");

            var a4 = 1;
            var b4 = 2;
            var c4 = 3;
            Console.WriteLine(c4 > b4 && c4 > a4); //true
            Console.WriteLine(c4 > b4 && c4 == a4); //false
            Console.WriteLine(c4 > b4 || c4 == a4); //true
            Console.WriteLine(!(c4 > b4 && c4 == a4)); //true
            Console.WriteLine("=================================");
        }
    }
}
