using System;

namespace _04_Classes
{
    public class Person
    {
        public string firstname;
        public string lastname;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstname +" " + lastname);
        }
    }
}
