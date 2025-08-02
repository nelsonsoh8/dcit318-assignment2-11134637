using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11134637_Q2
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle implementation
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value >= 0 ? value : throw new ArgumentException("Radius must be non-negative");
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle implementation
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get => _width;
            set => _width = value >= 0 ? value : throw new ArgumentException("Width must be non-negative");
        }

        public double Height
        {
            get => _height;
            set => _height = value >= 0 ? value : throw new ArgumentException("Height must be non-negative");
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create shapes
                Circle circle = new Circle { Radius = 5 };
                Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };

                // Calculate and display areas
                Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
                Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

                // Uncomment to test validation:
                // Circle badCircle = new Circle { Radius = -1 }; // Will throw exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}