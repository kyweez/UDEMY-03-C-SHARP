using System;

namespace _02_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            Console.WriteLine("===================================");

            int i2 = 1;
            byte b2 = (byte)i2;
            Console.WriteLine(b2);
            Console.WriteLine("===================================");

            int i3 = 256;
            byte b3 = (byte)i3;
            Console.WriteLine(b3);
            Console.WriteLine("===================================");


            string number = "1234";
            int i4 = Convert.ToInt32(number);
            Console.WriteLine(i4);
            Console.WriteLine("===================================");

            try
            {
                string number2 = "256";
                byte b4 = Convert.ToByte(number2);
                Console.WriteLine(b4);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't convert to a byte");
            }
            Console.WriteLine("===================================");

            try
            {
                string str = "true";
                bool b5 = Convert.ToBoolean(str);
                Console.WriteLine(b5);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't convert to a boolean");
            }
            Console.WriteLine("===================================");
        }
    }
}
