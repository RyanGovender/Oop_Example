using System;
using Test1.Models;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee emp = new Contract("Ben","Driver",4500,7);
            emp.Display();

            Employee emp2 = new Employee("Will","Driver",14000);
            emp2.Display();

            Employee emp3 = new Contract("Book", "Coder", 44500,0, 7,1,6);
            emp3.Display();

            Console.ReadKey();
        }
    }
}
