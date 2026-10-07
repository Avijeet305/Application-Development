namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        byte byteValue = 10;
        short shortValue = 1000;
        int intValue = 42;
        long longValue = 100000L;
        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

        // Type conversion
        string intToString = intValue.ToString();
        double stringToDouble = double.Parse("3.14");

        // Print all variables
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        Console.WriteLine($"int to string: {intToString}");
        Console.WriteLine($"string to double: {stringToDouble}");
    }
}