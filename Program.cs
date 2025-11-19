using Week4.Week4;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first student object
        Student student1 = new Student();

        // Assign values to instance fields of first student
        student1.name = "Shaolin";
        student1.age = 28;
        student1.major = "Mathematics";

        Student.studentCount++;

        Student student2 = new Student();

        student2.name = "Bobby";
        student2.age = 28;
        student2.major = "Computer Science";

        Student.studentCount++;

        Console.WriteLine("Student 1:");
        Console.WriteLine($"Name: {student1.name}, Age: {student1.age}, Major: {student1.major}");

        Console.WriteLine("Student 2:");
        Console.WriteLine($"Name: {student2.name}, Age: {student2.age}, Major: {student2.major}");

        Console.WriteLine($"Total number of students: {Student.studentCount}");

        Console.WriteLine("\n--- Calculator Operations ---");

        // Create a Calculator object
        Calculator calculator = new Calculator();

        // Call PrintWelcome method
        calculator.PrintWelcome();

        int additionResult = calculator.Add(10, 5);
        Console.WriteLine($"Addition of 10 and 5: {additionResult}");

        int multiplicationResult1 = calculator.Multiply(10, 5);
        Console.WriteLine($"Multiplication of 10 and 5: {multiplicationResult1}");

        int multiplicationResult2 = calculator.Multiply(10);
        Console.WriteLine($"Multiplication of 10 and 1 (default): {multiplicationResult2}");

        Console.WriteLine("\n--- Parameter Demo Operations ---");

        ParameterDemo paramDemo = new ParameterDemo();

        int number = 20;
        Console.WriteLine($"Original number: {number}");
        paramDemo.Increase(ref number);
        Console.WriteLine($"After Increase (ref parameter): {number}");

        string fullName;
        paramDemo.GetFullName(out fullName);
        Console.WriteLine($"Full Name (out parameter): {fullName}");

        int sum1 = paramDemo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of 1, 2, 3, 4, 5: {sum1}");

        int sum2 = paramDemo.SumAll(10, 20, 30);
        Console.WriteLine($"Sum of 10, 20, 30: {sum2}");

        int sum3 = paramDemo.SumAll(100);
        Console.WriteLine($"Sum of 100: {sum3}");

        Console.WriteLine("\n--- Player Constructor Demo ---");

        // Create first player object using default constructor
        Console.WriteLine("Creating Player 1 with default constructor:");
        Player player1 = new Player();

        player1.playerName = "Guest";
        player1.level = 1;
        player1.health = 100;

        Console.WriteLine($"Player 1 - Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");

        // Create second player object using parameterized constructor
        Console.WriteLine("\nCreating Player 2 with parameterized constructor:");
        Player player2 = new Player("WarriorKing", 25, 500);

        // Display field values of player2 object
        Console.WriteLine($"Player 2 - Name: {player2.playerName}, Level: {player2.level}, Health: {player2.health}");

        Console.WriteLine("\n--- Enum DayType Demo ---");

        // Ask user to input the day
        Console.Write("Enter a day (e.g., Sunday, Monday, etc.): ");
        string? userInput = Console.ReadLine();

        if (userInput != null)
        {
            string day = userInput.Trim();
            DayType dayType;

            if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            // Print the day type
            Console.WriteLine($"It is: {dayType}");
        }

        Console.WriteLine("\n--- Record Book Demo ---");

        Book book1 = new Book("Diary of wimpy kid", ". Jeff Kenny", 15.99);
        Console.WriteLine($"Book 1 - Title: {book1.title}, Author: {book1.author}, Price: ${book1.price}");

        // Create second book object using 'with' expression to change title and price
        Book book2 = book1 with { title = "1984", price = 12.99 };

        // Print the value of first object (unchanged)
        Console.WriteLine($"\nBook 1 (original) - Title: {book1.title}, Author: {book1.author}, Price: ${book1.price}");

        var (title, author, price) = book2;
        Console.WriteLine($"\nBook 2 (deconstructed variables):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: ${price}");

        Console.WriteLine("\n--- Debugging Exercise: Percentage Calculation ---");

        Console.Write("Enter marks obtained: ");
        string? marksInput = Console.ReadLine();

        // Ask user to input total marks
        Console.Write("Enter total marks: ");
        string? totalInput = Console.ReadLine();

        int marks = 0;
        int total = 0;
        bool isMarksValid = int.TryParse(marksInput, out marks);
        bool isTotalValid = int.TryParse(totalInput, out total);

        // Check if both inputs are valid
        if (isMarksValid && isTotalValid && total != 0)
        {

            double percentage = marks / total * 100;

            Console.WriteLine($"Percentage: {percentage}%");


            Console.WriteLine("\n--- CORRECTED VERSION ---");
            double correctPercentage = (double)marks / total * 100;
            Console.WriteLine($"Correct Percentage: {correctPercentage}%");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter valid integers and ensure total is not zero.");
        }
    }
}