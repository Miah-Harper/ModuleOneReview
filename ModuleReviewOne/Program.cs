namespace ModuleReviewOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number to calculate the area of a circle");
            var area = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle is: {AreaOfCircle(area)}");

            Console.WriteLine("Type in the first number to get the area of a triangle");
            var baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Type in the second number");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the triangle is: {AreaOfTriangle(baseLength, height)}");

            Console.WriteLine("Type in the first number for area of a rectangle");
            var length = double.Parse(Console.ReadLine());
            Console.WriteLine("Type in a second number");
            var width = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the rectangle is: {AreaOfRectangle(length, width)}");

            Console.WriteLine("Type in a number to get the area of a square");
            var side = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the square is {AreaOfSquare(side)}");
        }

        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public static double AreaOfTriangle(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaOfSquare(double side)
        {
            return side * side;
        }

    }
}

