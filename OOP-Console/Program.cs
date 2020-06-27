using System;
using System.Collections.Generic;

namespace OOP_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var myclass = new MyClass();
            var myclass2 = new MyClass2();

            var list = new List<IMyClass>();
            list.Add(myclass);
            list.Add(myclass2);

            foreach(var item in list)
            {
                Console.WriteLine(item.Foo());
                Console.WriteLine(item.Bar());
            }
        }
    }
}