using System;

namespace dotnet.src.SessionThree.AppInterface
{
    public interface IShapeArea
    {
        // Only method signature, abstract by default
        double getArea();
    }

    public interface IShapeDraw
    {
        void getPosition();
    }

    // Multiple inheritance
    public abstract class CommonShape : IShapeArea, IShapeDraw
    {
        private int id;

        public abstract string Name { get; set; }

        public abstract double getArea();
        public abstract void getPosition();

        public int getId()
        {
            return this.id;
        }
    }

    // Hybrid inheritance
    public class Circle : CommonShape
    {
        // Fields
        private double radius = 10; // Fixed the case for 'radius'
        private string name = "Circle"; 

        // Property with accessors
        public override string Name
        {
            get { return name; }
            set { name = value; } // Corrected '_name' to 'name'
        }

        // Added the Radius property correctly
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Overriding getArea method
        public override double getArea()
        {
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }

        // Overriding getPosition method
        public override void getPosition()
        {
            Console.WriteLine($"/-----drawing a {Name}-----/");
        }
    }

    public static class ShapeManager
    {
        // Method to print shape info
        public static void PrintShapeInfo(CommonShape shape)
        {
            shape.getPosition();
            Console.WriteLine($"Shape Name: {shape.Name}");
            Console.WriteLine($"Area: {shape.getArea()}");
        }
    }
}
