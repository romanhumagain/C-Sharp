using System;

class Program
{
    // Main method where the program starts
    static void Main()
    {
        // Prompt the user for their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // Read user input for name

        // Prompt the user for their age
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine(); // Read user input for age

        // Prompt the user for their favorite number
        Console.Write("Enter your favorite number: ");
        string numberInput = Console.ReadLine(); // Read user input for favorite number

        // Convert the age and favorite number from strings to integers
        int age = Convert.ToInt32(ageInput); // Convert age from string to integer
        int favoriteNumber = Convert.ToInt32(numberInput); // Convert favorite number from string to integer

        // Calculate the number of years remaining until the user turns 100
        int yearsTo100 = CalculateYearsTo100(age);

        // Determine if the user's age is even or odd
        string ageEvenOdd = DetermineAgeEvenOdd(age);

        // Display the personalized greeting message using concatenation
        Console.WriteLine("Hello " + name + "!");
        Console.WriteLine("You are " + age + " years old.");

        // Display the number of years left until the user turns 100
        Console.WriteLine("You have " + yearsTo100 + " years left until you turn 100.");

        // Display whether the user's age is even or odd
        Console.WriteLine("Your age is " + ageEvenOdd + ".");

        // Display the same information using string interpolation
        Console.WriteLine($"\nHello {name}!");
        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine($"You have {yearsTo100} years left until you turn 100.");
        Console.WriteLine($"Your age is {ageEvenOdd}.");
    }

    // Method to calculate the number of years until the user turns 100
    static int CalculateYearsTo100(int age)
    {
        return 100 - age; // Calculate the difference between 100 and the user's age
    }

    // Method to determine if the user's age is even or odd
    static string DetermineAgeEvenOdd(int age)
    {
        if (age % 2 == 0)
        {
            return "even"; // Return "even" if age is divisible by 2
        }
        else
        {
            return "odd"; // Return "odd" if age is not divisible by 2
        }
    }
}
