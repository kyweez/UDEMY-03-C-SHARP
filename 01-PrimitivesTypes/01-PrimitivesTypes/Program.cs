using System;

namespace _01_PrimitivesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 10.21f;
            char character = 'q';
            string firstName = "Test";
            bool isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("==========================\n");

            var number2 = 2;
            var count2 = 10;
            var totalPrice2 = 10.21f;
            var character2 = 'q';
            var firstName2 = "Test";
            var isWorking2 = false;
            Console.WriteLine(number2);
            Console.WriteLine(count2);
            Console.WriteLine(totalPrice2);
            Console.WriteLine(character2);
            Console.WriteLine(firstName2);
            Console.WriteLine(isWorking2);
            Console.WriteLine("==========================\n");

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("==========================\n");

            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            Console.WriteLine("==========================\n");
        }
    }
}
