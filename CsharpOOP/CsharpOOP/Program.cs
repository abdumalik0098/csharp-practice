using System;

namespace CsharpOOP
{
    struct Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public  void Info()
        {
            Console.WriteLine($"Name: {name}, Age: {age} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP- 1");
            Person dev;
            dev.name = "Ali";
            dev.age = 24;
            dev.Info();
            // Console.ReadKey();

            Person manager = new Person("Jack", 34);
            manager.Info();
            Person klient = new Person("Kareem", 27);
            klient.Info();

        }
    }
}
