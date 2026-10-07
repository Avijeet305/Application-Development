namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Birthdate
        DateTime birthDate = new DateTime(2003, 5, 15);

        // Current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate TimeSpan
        TimeSpan ageSpan = currentDate - birthDate;

        // Calculate age in years
        int age = (int)(ageSpan.TotalDays / 365.25);

        // Print details
        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate after adding 10 days: {newDate:yyyy-MM-dd}");
    }
}