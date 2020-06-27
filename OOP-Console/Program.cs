using System;
using System.Collections.Generic;

namespace OOP_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();

            animals.Add(new Dog());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Fox());
            
            foreach(var animal in animals){
                Console.WriteLine(animal.MakeSound() + ",");
            }

        }
    }
}