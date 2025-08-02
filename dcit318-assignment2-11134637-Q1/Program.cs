using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11134637_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.MakeSound();  
            dog.MakeSound();     
            cat.MakeSound();     

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();  
        }
    }
}