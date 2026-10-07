namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of 5 favorite numbers
        int[] numbers = { 7, 3, 9, 1, 5 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element using for loop
        Console.WriteLine("Array elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a specific number
        int searchNumber = 5;
        int position = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine($"Position of {searchNumber}: {position}");
    }
}