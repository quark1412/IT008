namespace Lab1_1
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double CoordX { get; set; }
            public abstract double CoordY { get; set; }
            public abstract string Name { get; set; }
            public abstract double CalculateArea();
            public abstract void Draw();
        }

        public class Circle : Shape
        {
            public override double CoordX { get; set; }
            public override double CoordY { get; set; }
            public override string Name { get; set; }
            public double Radius { get; set; }
            public Circle(double coordX, double coordY, double radius)
            {
                Name = "Circle";
                CoordX = coordX;
                CoordY = coordY;
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Radius * Radius * Math.PI;
            }

            public override void Draw()
            {
                Console.WriteLine($"{Name} :\n Radius {Radius}\n Coordinates ({CoordX},{CoordY})");
            }
        }
        public class Rectangle : Shape
        {
            public override double CoordX { get; set; }
            public override double CoordY { get; set; }
            public override string Name { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public Rectangle(double coordX, double coordY, double width, double height)
            {
                Name = "Rectangular";
                CoordX = coordX;
                CoordY = coordY;
                Width = width;
                Height = height;
            }
            public override double CalculateArea()
            {
                return Width * Height;
            }
            public override void Draw()
            {
                Console.WriteLine($"{Name} :\n Height {Height}, width {Width}\n Coordinates ({CoordX},{CoordY})");
            }
        }
        public class Triangle : Shape
        {
            public override double CoordX { get; set; }
            public override double CoordY { get; set; }
            public override string Name { get; set; }
            public double BaseLength { get; set; }
            public double Height { get; set; }
            public Triangle(double coordX, double coordY, double baseLength, double height)
            {
                Name = "Triangle";
                CoordX = coordX;
                CoordY = coordY;
                BaseLength = baseLength;
                Height = height;
            }
            public override double CalculateArea()
            {
                return 0.5 * BaseLength * Height;
            }
            public override void Draw()
            {
                Console.WriteLine($"{Name} :\n Base length: {BaseLength}, height {Height}\n Coordinates ({CoordX},{CoordY})");
            }
        }

        class Square : Rectangle
        {
            public override string Name { get; set; }
            public Square(double coordX, double coordY, double side) : base(coordX, coordY, side, side)
            {
                Name = "Square";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of images: ");
            int n = int.Parse(Console.ReadLine());

            string[] shapesName = new string[] { "Circle", "Rectangle", "Triangle", "Square" };

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {

                int choice = new Random().Next(0, 4);

                Console.WriteLine($"\nThe selected image is: {shapesName[choice]}\n");

                Console.Write("Enter X coordinates: ");
                double coordX = double.Parse(Console.ReadLine());

                Console.Write("Enter Y coordinates: ");
                double coordY = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.Write("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());

                        shapes.Add(new Circle(coordX, coordY, radius));
                        break;
                    case 1:
                        Console.Write("Enter width: ");
                        double width = double.Parse(Console.ReadLine());

                        Console.Write("Enter height: ");
                        double height = double.Parse(Console.ReadLine());

                        shapes.Add(new Rectangle(coordX, coordY, width, height));
                        break;
                    case 2:
                        Console.Write("Enter the base length: ");
                        double baseLength = double.Parse(Console.ReadLine());

                        Console.Write("Enter the height: ");
                        double heightLength = double.Parse(Console.ReadLine());

                        shapes.Add(new Triangle(coordX, coordY, baseLength, heightLength));
                        break;
                    case 3:
                        Console.Write("Enter the side length: ");
                        double side = double.Parse(Console.ReadLine());

                        shapes.Add(new Square(coordX, coordY, side));
                        break;
                    default:
                        Console.WriteLine("Invalid type");
                        break;

                }

            }

            Console.WriteLine("\nInformation about imported images:");
            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine($" Area: {shape.CalculateArea()}");
                Console.WriteLine();
            }
        }
    }
}