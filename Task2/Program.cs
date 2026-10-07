namespace Task2;

class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Try to modify the constant value
        // Circle.PI = 3.14159;

        double radius = 5;

        Console.WriteLine($"Area: {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter: {Circle.CalculatePerimeter(radius)}");
    }
}                                                        
