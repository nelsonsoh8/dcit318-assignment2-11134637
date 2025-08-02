using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dcit318_assignment2_11134637_Q3
{
    // 1. Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // 2. Create Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // 3. Create Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // 4. Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Interfaces:");

            // Create instances
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call Move() on each instance
            car.Move();
            bicycle.Move();

         
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
