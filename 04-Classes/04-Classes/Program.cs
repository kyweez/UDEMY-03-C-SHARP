using _04_Classes.Math;

namespace _04_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.firstname = "John";
            john.lastname = "Doe";
            john.Introduce();

            Calculator calculator = new Calculator();

            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
