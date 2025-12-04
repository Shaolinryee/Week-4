using week4.week6;
using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("\n--- Rectangle Expression-Bodied Members Demo ---");
\
        // Create a Rectangle object
        Rectangle rectangle = new Rectangle();

        // Set length and breadth using expression-bodied properties
        rectangle.Length = 10.5;
        rectangle.Breadth = 5.5;

        // Display rectangle details using expression-bodied method
        Console.WriteLine(rectangle.ShowDetails());

        // Calculate and display area using expression-bodied method
        double area = rectangle.GetArea();
        Console.WriteLine($"Area: {area} square units");

        // Calculate and display perimeter using expression-bodied method
        double perimeter = rectangle.GetPerimeter();
        Console.WriteLine($"Perimeter: {perimeter} units");

        // Create another rectangle with different dimensions
        Console.WriteLine("\n--- Second Rectangle ---");
        Rectangle rectangle2 = new Rectangle
        {
            Length = 8.0,
            Breadth = 6.0
        };

        Console.WriteLine(rectangle2.ShowDetails());
        Console.WriteLine($"Area: {rectangle2.GetArea()} square units");
        Console.WriteLine($"Perimeter: {rectangle2.GetPerimeter()} units");

        Console.WriteLine("\n--- Calculate Delegate Demo ---");

        // Create a Calculate delegate and assign the Add method
        Calculate calculateDelegate = Calculator.Add;

        // Call Add method using the delegate
        int sum = calculateDelegate(25, 15);
        Console.WriteLine($"Addition using delegate: 25 + 15 = {sum}");

        // Reassign the delegate to the Subtract method
        calculateDelegate = Calculator.Subtract;

        // Call Subtract method using the delegate
        int difference = calculateDelegate(25, 15);
        Console.WriteLine($"Subtraction using delegate: 25 - 15 = {difference}");

        Console.WriteLine("\n--- Discount Strategy Delegate Demo ---");

        // Define original price
        double originalPrice = 1000.00;
        Console.WriteLine($"Original Price: ${originalPrice}");

        // Call CalculateFinalPrice with FestivalDiscount strategy (20% off)
        Console.WriteLine("\n--- Festival Discount (20% off) ---");
        double festivalPrice = PricingService.CalculateFinalPrice(originalPrice, PricingService.FestivalDiscount);
        Console.WriteLine($"Final Price after Festival Discount: ${festivalPrice}");

        // Call CalculateFinalPrice with SeasonalDiscount strategy (10% off)
        Console.WriteLine("\n--- Seasonal Discount (10% off) ---");
        double seasonalPrice = PricingService.CalculateFinalPrice(originalPrice, PricingService.SeasonalDiscount);
        Console.WriteLine($"Final Price after Seasonal Discount: ${seasonalPrice}");

        // Call CalculateFinalPrice with NoDiscount strategy
        Console.WriteLine("\n--- No Discount ---");
        double regularPrice = PricingService.CalculateFinalPrice(originalPrice, PricingService.NoDiscount);
        Console.WriteLine($"Final Price with No Discount: ${regularPrice}");

        // Call CalculateFinalPrice with a Lambda expression (30% off)
        Console.WriteLine("\n--- Lambda Expression Discount (30% off) ---");
        double lambdaPrice = PricingService.CalculateFinalPrice(originalPrice, (price) => price - (price * 0.30));
        Console.WriteLine($"Final Price with Lambda (30% discount): ${lambdaPrice}");

        // Additional demo: Using different prices with lambda expressions
        Console.WriteLine("\n--- More Lambda Expression Examples ---");
        double price1 = 500.00;
        double price2 = 1500.00;

        // 15% discount using lambda
        double discount15 = PricingService.CalculateFinalPrice(price1, p => p * 0.85);
        Console.WriteLine($"${price1} with 15% off (lambda): ${discount15}");

        // 50% discount using lambda
        double discount50 = PricingService.CalculateFinalPrice(price2, p => p / 2);
        Console.WriteLine($"${price2} with 50% off (lambda): ${discount50}");

        Console.WriteLine("\n--- Func Delegate Demo (ProcessNumbers) ---");

        // Create an array of numbers to process
        int[] numbers = { 5, 12, 8, 3, 21, 15, 6, 18, 9, 11 };
        Console.WriteLine($"Original Numbers: {string.Join(", ", numbers)}");

        // Print only even numbers using Func delegate with named method
        Console.WriteLine("\n--- Even Numbers (using method reference) ---");
        NumberProcessor.ProcessNumbers(numbers, NumberProcessor.IsEven);

        // Print only numbers greater than 10 using Func delegate with named method
        Console.WriteLine("\n--- Numbers Greater Than 10 (using method reference) ---");
        NumberProcessor.ProcessNumbers(numbers, NumberProcessor.IsGreaterThan10);

        // Using lambda expressions with Func delegate
        Console.WriteLine("\n--- Even Numbers (using lambda expression) ---");
        NumberProcessor.ProcessNumbers(numbers, n => n % 2 == 0);

        Console.WriteLine("\n--- Numbers Greater Than 10 (using lambda expression) ---");
        NumberProcessor.ProcessNumbers(numbers, n => n > 10);

        // Additional examples with different conditions
        Console.WriteLine("\n--- Numbers Less Than 10 (using lambda) ---");
        NumberProcessor.ProcessNumbers(numbers, n => n < 10);

        Console.WriteLine("\n--- Odd Numbers (using lambda) ---");
        NumberProcessor.ProcessNumbers(numbers, n => n % 2 != 0);

        Console.WriteLine("\n--- Numbers Between 10 and 20 (using lambda) ---");
        NumberProcessor.ProcessNumbers(numbers, n => n >= 10 && n <= 20);

        Console.WriteLine("\n--- Numbers Divisible by 3 (using lambda) ---");
        NumberProcessor.ProcessNumbers(numbers, n => n % 3 == 0);

        Console.WriteLine("\n========================================");
        Console.WriteLine("         LINQ OPERATIONS DEMO");
        Console.WriteLine("========================================");

        // ===== LINQ PROJECTION (SELECT) =====
        Console.WriteLine("\n--- LINQ Projection: Square Each Number ---");

        // Create a list of integers
        List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Original Numbers: {string.Join(", ", numbersList)}");

        // Use LINQ Select to square each number
        var squaredNumbers = numbersList.Select(n => n * n).ToList();

        // Print the squared numbers
        Console.WriteLine($"Squared Numbers: {string.Join(", ", squaredNumbers)}");

        // Alternative: Using query syntax
        var squaredQuery = (from n in numbersList
                            select n * n).ToList();
        Console.WriteLine($"Squared (Query Syntax): {string.Join(", ", squaredQuery)}");

        // ===== LINQ FILTERING (WHERE) =====
        Console.WriteLine("\n--- LINQ Filtering: Premium Books Above Rs. 1000 ---");

        // Create a list of books with prices
        List<Book> booksList = new List<Book>
        {
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 750.00),
            new Book("1984", "George Orwell", 1200.00),
            new Book("To Kill a Mockingbird", "Harper Lee", 950.00),
            new Book("Pride and Prejudice", "Jane Austen", 1500.00),
            new Book("The Catcher in the Rye", "J.D. Salinger", 850.00),
            new Book("Harry Potter", "J.K. Rowling", 1350.00),
            new Book("The Hobbit", "J.R.R. Tolkien", 1100.00),
            new Book("Animal Farm", "George Orwell", 600.00)
        };

        Console.WriteLine("\nAll Books in Bookstore:");
        foreach (var book in booksList)
        {
            Console.WriteLine($"  {book}");
        }

        // Use LINQ Where to filter premium books (price > Rs. 1000)
        var premiumBooks = booksList.Where(book => book.Price > 1000).ToList();

        Console.WriteLine($"\nPremium Books (Price > Rs. 1000): {premiumBooks.Count} books found");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine($"  {book}");
        }

        // Alternative: Using query syntax
        var premiumBooksQuery = (from book in booksList
                                 where book.Price > 1000
                                 select book).ToList();

        Console.WriteLine($"\nPremium Books (Query Syntax): {premiumBooksQuery.Count} books");

        // ===== LINQ SORTING (ORDERBY) =====
        Console.WriteLine("\n--- LINQ Sorting: AAA Scholarship Students (Alphabetically) ---");

        // Create a list of 10 students for AAA scholarship
        List<Student> scholarshipStudents = new List<Student>
        {
            new Student("Zara Williams", "ISL001", 4.0),
            new Student("Alice Johnson", "ISL002", 4.0),
            new Student("Michael Brown", "ISL003", 4.0),
            new Student("Emily Davis", "ISL004", 4.0),
            new Student("David Wilson", "ISL005", 4.0),
            new Student("Sarah Martinez", "ISL006", 4.0),
            new Student("James Anderson", "ISL007", 4.0),
            new Student("Olivia Taylor", "ISL008", 4.0),
            new Student("Benjamin Moore", "ISL009", 4.0),
            new Student("Emma White", "ISL010", 4.0)
        };

        Console.WriteLine("\nAAA Scholarship Students (Unsorted):");
        foreach (var student in scholarshipStudents)
        {
            Console.WriteLine($"  {student}");
        }

        // Use LINQ OrderBy to sort students alphabetically by name
        var sortedStudents = scholarshipStudents.OrderBy(s => s.Name).ToList();

        Console.WriteLine("\nAAA Scholarship Students (Sorted Alphabetically):");
        int rank = 1;
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"  {rank}. {student}");
            rank++;
        }

        // Alternative: Using query syntax
        var sortedStudentsQuery = (from student in scholarshipStudents
                                   orderby student.Name
                                   select student).ToList();

        Console.WriteLine("\nSorted Students (Query Syntax):");
        foreach (var student in sortedStudentsQuery.Take(3))
        {
            Console.WriteLine($"  {student}");
        }

        // Bonus: OrderByDescending example
        Console.WriteLine("\nStudents in Reverse Alphabetical Order:");
        var reverseStudents = scholarshipStudents.OrderByDescending(s => s.Name).Take(3).ToList();
        foreach (var student in reverseStudents)
        {
            Console.WriteLine($"  {student}");
        }

        Console.WriteLine("\n========================================");
        Console.WriteLine("    LINQ ADVANCED OPERATIONS DEMO");
        Console.WriteLine("========================================");

        // ===== LINQ AGGREGATION OPERATORS =====
        Console.WriteLine("\n--- LINQ Aggregation: Supermarket Daily Sales ---");

        // Create a list of cashier sales for the day
        List<CashierSales> cashierSalesList = new List<CashierSales>
        {
            new CashierSales("Ram Sharma", 101, 25000.50),
            new CashierSales("Sita Thapa", 102, 32500.75),
            new CashierSales("Hari Prasad", 103, 18750.00),
            new CashierSales("Maya Singh", 104, 41200.25),
            new CashierSales("Krishna Rai", 105, 29800.00),
            new CashierSales("Gita Gurung", 106, 35600.50),
            new CashierSales("Bikash Tamang", 107, 22400.00)
        };

        Console.WriteLine("\nDaily Sales Report:");
        foreach (var cashier in cashierSalesList)
        {
            Console.WriteLine($"  {cashier}");
        }

        // Calculate total number of cashiers using Count()
        int totalCashiers = cashierSalesList.Count();
        Console.WriteLine($"\nTotal Number of Cashiers: {totalCashiers}");

        // Calculate total sales using Sum()
        double totalSales = cashierSalesList.Sum(c => c.DailySales);
        Console.WriteLine($"Total Sales of the Day: Rs. {totalSales:F2}");

        // Calculate highest sales using Max()
        double highestSales = cashierSalesList.Max(c => c.DailySales);
        Console.WriteLine($"Highest Sales: Rs. {highestSales:F2}");

        // Find cashier with highest sales
        var topCashier = cashierSalesList.FirstOrDefault(c => c.DailySales == highestSales);
        Console.WriteLine($"Top Performer: {topCashier?.CashierName}");

        // Calculate lowest sales using Min()
        double lowestSales = cashierSalesList.Min(c => c.DailySales);
        Console.WriteLine($"Lowest Sales: Rs. {lowestSales:F2}");

        // Calculate average sales using Average()
        double averageSales = cashierSalesList.Average(c => c.DailySales);
        Console.WriteLine($"Average Sales: Rs. {averageSales:F2}");

        // ===== LINQ QUANTIFIER OPERATORS (ANY/ALL) =====
        Console.WriteLine("\n--- LINQ Quantifier: Election Commission Applicants ---");

        // Create a list of applicants
        List<Applicant> applicantsList = new List<Applicant>
        {
            new Applicant("Rajesh Kumar", 25, "12-345-678"),
            new Applicant("Anjali Devi", 17, "12-345-679"),
            new Applicant("Suresh Bahadur", 32, "12-345-680"),
            new Applicant("Priya Sharma", 19, "12-345-681"),
            new Applicant("Arjun Singh", 16, "12-345-682"),
            new Applicant("Kritika Rai", 28, "12-345-683"),
            new Applicant("Nabin Thapa", 21, "12-345-684")
        };

        Console.WriteLine("\nApplicants List:");
        foreach (var applicant in applicantsList)
        {
            Console.WriteLine($"  {applicant}");
        }

        // Check if ANY applicant is under 18 using Any()
        bool anyUnder18 = applicantsList.Any(a => a.Age < 18);
        Console.WriteLine($"\nAre there any applicants under 18? {(anyUnder18 ? "YES" : "NO")}");

        if (anyUnder18)
        {
            var under18List = applicantsList.Where(a => a.Age < 18).ToList();
            Console.WriteLine("Applicants under 18:");
            foreach (var applicant in under18List)
            {
                Console.WriteLine($"  {applicant}");
            }
        }

        // Check if ALL applicants are above 16 using All()
        bool allAbove16 = applicantsList.All(a => a.Age > 16);
        Console.WriteLine($"\nAre all applicants above 16? {(allAbove16 ? "YES" : "NO")}");

        if (!allAbove16)
        {
            var age16OrBelow = applicantsList.Where(a => a.Age <= 16).ToList();
            Console.WriteLine("Applicants aged 16 or below:");
            foreach (var applicant in age16OrBelow)
            {
                Console.WriteLine($"  {applicant}");
            }
        }

        // Additional quantifier examples
        bool anyAbove30 = applicantsList.Any(a => a.Age > 30);
        Console.WriteLine($"\nAre there any applicants above 30? {(anyAbove30 ? "YES" : "NO")}");

        bool allAbove15 = applicantsList.All(a => a.Age > 15);
        Console.WriteLine($"Are all applicants above 15? {(allAbove15 ? "YES" : "NO")}");

        // ===== LINQ ELEMENT OPERATORS (FIRST, LAST, FIRSTORDEFAULT) =====
        Console.WriteLine("\n--- LINQ Element Operators: Music App Song Durations ---");

        // Create a list of songs with durations in seconds
        List<Music> playlist = new List<Music>
        {
            new Music("Shape of You", "Ed Sheeran", 234),           // 3:54
            new Music("Blinding Lights", "The Weeknd", 200),        // 3:20
            new Music("Bohemian Rhapsody", "Queen", 355),           // 5:55
            new Music("Stairway to Heaven", "Led Zeppelin", 482),   // 8:02
            new Music("Hotel California", "Eagles", 391),           // 6:31
            new Music("Imagine", "John Lennon", 183),               // 3:03
            new Music("November Rain", "Guns N' Roses", 537)        // 8:57
        };

        Console.WriteLine("\nPlaylist:");
        foreach (var song in playlist)
        {
            Console.WriteLine($"  {song}");
        }

        // Find the FIRST song using First()
        var firstSong = playlist.First();
        Console.WriteLine($"\nFirst Song: {firstSong}");

        // Find the LAST song using Last()
        var lastSong = playlist.Last();
        Console.WriteLine($"Last Song: {lastSong}");

        // Find the first song with duration above 4 minutes (240 seconds) using First()
        var firstSongAbove4Min = playlist.First(s => s.DurationInSeconds > 240);
        Console.WriteLine($"\nFirst Song Above 4 Minutes: {firstSongAbove4Min}");

        // Find the first song longer than 10 minutes (600 seconds) using FirstOrDefault()
        // This returns null if no song matches (safe result)
        var firstSongAbove10Min = playlist.FirstOrDefault(s => s.DurationInSeconds > 600);

        if (firstSongAbove10Min != null)
        {
            Console.WriteLine($"\nFirst Song Above 10 Minutes: {firstSongAbove10Min}");
        }
        else
        {
            Console.WriteLine("\nFirst Song Above 10 Minutes: No song found (safe result with FirstOrDefault)");
        }

        // Additional element operator examples
        Console.WriteLine("\n--- Additional Element Operator Examples ---");

        // Last song with duration below 4 minutes
        var lastSongBelow4Min = playlist.Last(s => s.DurationInSeconds < 240);
        Console.WriteLine($"Last Song Below 4 Minutes: {lastSongBelow4Min}");

        // FirstOrDefault for songs above 5 minutes (300 seconds)
        var firstSongAbove5Min = playlist.FirstOrDefault(s => s.DurationInSeconds > 300);
        Console.WriteLine($"First Song Above 5 Minutes: {firstSongAbove5Min?.SongTitle ?? "Not found"}");

        // LastOrDefault example
        var lastSongAbove9Min = playlist.LastOrDefault(s => s.DurationInSeconds > 540);
        Console.WriteLine($"Last Song Above 9 Minutes: {lastSongAbove9Min?.SongTitle ?? "Not found"}");

        Console.WriteLine("\n========================================");
        Console.WriteLine("  TRAVEL COMPANY - TOUR BOOKING REPORT");
        Console.WriteLine("========================================");

        // Create a list of tour bookings
        List<TourBooking> tourBookings = new List<TourBooking>
        {
            new TourBooking("Ramesh Sharma", "Pokhara", 8500.00, 3, false),
            new TourBooking("Anjali Thapa", "Dubai", 65000.00, 7, true),
            new TourBooking("Suresh Kumar", "Chitwan", 12000.00, 5, false),
            new TourBooking("Priya Singh", "Thailand", 45000.00, 6, true),
            new TourBooking("Bikash Rai", "Mustang", 25000.00, 8, false),
            new TourBooking("Sita Gurung", "Ilam", 6000.00, 2, false),
            new TourBooking("Krishna Tamang", "Singapore", 75000.00, 5, true),
            new TourBooking("Maya Shrestha", "Lumbini", 15000.00, 4, false),
            new TourBooking("Hari Prasad", "Paris", 150000.00, 10, true),
            new TourBooking("Gita Devi", "Kathmandu Valley", 9500.00, 3, false),
            new TourBooking("Nabin Karki", "Maldives", 95000.00, 7, true),
            new TourBooking("Kritika Bhatta", "Manang", 18000.00, 6, false),
            new TourBooking("Arjun Basnet", "Malaysia", 55000.00, 8, true),
            new TourBooking("Sunita Poudel", "Bardiya", 11000.00, 5, false)
        };

        Console.WriteLine("\n--- ALL TOUR BOOKINGS ---");
        Console.WriteLine($"Total Bookings: {tourBookings.Count}");
        foreach (var booking in tourBookings)
        {
            Console.WriteLine($"  {booking}");
        }

        // STEP 1: FILTER tours above Rs. 10,000 AND duration more than 4 days
        Console.WriteLine("\n--- APPLYING FILTERS ---");
        Console.WriteLine("Filter Criteria:");
        Console.WriteLine("  1. Price > Rs. 10,000");
        Console.WriteLine("  2. Duration > 4 days");

        var filteredTours = tourBookings
            .Where(t => t.Price > 10000 && t.DurationInDays > 4)
            .ToList();

        Console.WriteLine($"\nFiltered Results: {filteredTours.Count} bookings found");
        foreach (var tour in filteredTours)
        {
            Console.WriteLine($"  {tour}");
        }

        // STEP 2: TRANSFORM (Project) the filtered list into TourSummary
        Console.WriteLine("\n--- TRANSFORMING DATA ---");
        Console.WriteLine("Creating summary with CustomerName, Destination, and Category");

        var tourSummaries = filteredTours
            .Select(t => new TourSummary(
                t.CustomerName,
                t.Destination,
                t.IsInternational ? "International" : "Domestic",
                t.Price
            ))
            .ToList();

        Console.WriteLine($"\nTransformed Data: {tourSummaries.Count} records");

        // STEP 3: SORT by Category (Domestic first, then International), then by Price
        Console.WriteLine("\n--- SORTING DATA ---");
        Console.WriteLine("Sort Order:");
        Console.WriteLine("  1. Category (Domestic first, then International)");
        Console.WriteLine("  2. Price (ascending within each category)");

        var sortedTourSummaries = tourSummaries
            .OrderBy(t => t.Category)           // Sort by Category (Domestic comes before International alphabetically)
            .ThenBy(t => t.Price)               // Then sort by Price within each category
            .ToList();

        // STEP 4: DISPLAY in clean format
        Console.WriteLine("\n========================================");
        Console.WriteLine("     MARKET ANALYSIS SUMMARY REPORT");
        Console.WriteLine("========================================");
        Console.WriteLine("\nFiltered Tours (Price > Rs. 10,000 AND Duration > 4 days)");
        Console.WriteLine("Sorted by: Category (Domestic → International), then Price");
        Console.WriteLine("\n" + new string('-', 90));

        string currentCategory = "";
        int count = 1;

        foreach (var summary in sortedTourSummaries)
        {
            // Print category header when it changes
            if (currentCategory != summary.Category)
            {
                currentCategory = summary.Category;
                Console.WriteLine($"\n{currentCategory.ToUpper()} TOURS:");
                Console.WriteLine(new string('-', 90));
                count = 1;
            }

            Console.WriteLine($"{count}. {summary}");
            count++;
        }

        Console.WriteLine("\n" + new string('-', 90));

        // STEP 5: ADDITIONAL STATISTICS
        Console.WriteLine("\n--- SUMMARY STATISTICS ---");

        var domesticTours = sortedTourSummaries.Where(t => t.Category == "Domestic").ToList();
        var internationalTours = sortedTourSummaries.Where(t => t.Category == "International").ToList();

        Console.WriteLine($"\nDomestic Tours: {domesticTours.Count}");
        if (domesticTours.Any())
        {
            Console.WriteLine($"  Average Price: Rs. {domesticTours.Average(t => t.Price):F2}");
            Console.WriteLine($"  Highest Price: Rs. {domesticTours.Max(t => t.Price):F2}");
            Console.WriteLine($"  Lowest Price: Rs. {domesticTours.Min(t => t.Price):F2}");
        }

        Console.WriteLine($"\nInternational Tours: {internationalTours.Count}");
        if (internationalTours.Any())
        {
            Console.WriteLine($"  Average Price: Rs. {internationalTours.Average(t => t.Price):F2}");
            Console.WriteLine($"  Highest Price: Rs. {internationalTours.Max(t => t.Price):F2}");
            Console.WriteLine($"  Lowest Price: Rs. {internationalTours.Min(t => t.Price):F2}");
        }

        Console.WriteLine($"\nTotal Revenue (Filtered Tours): Rs. {sortedTourSummaries.Sum(t => t.Price):F2}");

        Console.WriteLine("\n========================================");
        Console.WriteLine("         END OF REPORT");
        Console.WriteLine("========================================");


    }
}