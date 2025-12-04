
public class Program
{
    public delegate int Calculate(int num1, int num2);
    public delegate double DiscountStrategy(double price);
    public  void main (string[] args)
    {
        // Rectangle rect = new Rectangle();
        // rect.Length = 10;
        // rect.Breadth = 5;
        // rect.ShowDetails();
        Delegate task = new Delegate();
        Calculate cal;
        cal = task.Add;
        Console.WriteLine("Addition: " + cal(10, 5));
        DiscountStrategy discountStrategy;
        discountStrategy = task.SeasonalDiscount;
        Console.WriteLine($"Seasonal Discount price :{discountStrategy(1000)}");
        discountStrategy = task.FeastiveDiscount;
        Console.WriteLine($"Seasonal Discount price :{discountStrategy(1000)}");
        discountStrategy = task.NoDiscount;
        Console.WriteLine($"Seasonal Discount price :{discountStrategy(1000)}");

        double originalPrice = 1000;

        // 2.2 Call methods one by one
        Console.WriteLine("10% Discount: " +
            DiscountCalculator.CalculateFinalPrice(originalPrice, 
            DiscountCalculator.TenPercentDiscount));

        Console.WriteLine("20% Discount: " +
            DiscountCalculator.CalculateFinalPrice(originalPrice, 
            DiscountCalculator.TwentyPercentDiscount));

        Console.WriteLine("No Discount: " +
            DiscountCalculator.CalculateFinalPrice(originalPrice, 
            DiscountCalculator.NoDiscount));

        // 2.3 Lambda expression (30% discount)
        double lambdaResult =
            DiscountCalculator.CalculateFinalPrice(originalPrice, 
            p => p - (p * 0.30));

        Console.WriteLine("30% Discount (Lambda): " + lambdaResult);

         int[] values = { 3, 8, 12, 5, 20, 11, 7, 14 };

        Console.WriteLine("Even numbers:");
        NumberProcessor.ProcessNumbers(values, n => n % 2 == 0);

        Console.WriteLine("\nNumbers greater than 10:");
        NumberProcessor.ProcessNumbers(values, n => n > 10);


        // 1. Selecting / Projection
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squaredNumbers = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared Numbers:");
        foreach (var n in squaredNumbers)
            Console.WriteLine(n);

        Console.WriteLine();

        // 2. Filtering Books (Where)
        List<Book> books = new List<Book>
        {
            new Book { Title = "C# Basics", Price = 800 },
            new Book { Title = "Advanced Java", Price = 1200 },
            new Book { Title = "Data Structures", Price = 1500 },
            new Book { Title = "Web Dev", Price = 950 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("Books Above Rs. 1000:");
        foreach (var b in premiumBooks)
            Console.WriteLine(b.Title + " - " + b.Price);

        Console.WriteLine();

        // 3. Sorting Students (OrderBy)
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sujal" },
            new Student { Name = "Aayush" },
            new Student { Name = "Bibek" },
            new Student { Name = "Kabita" },
            new Student { Name = "Sandesh" },
            new Student { Name = "Prabin" },
            new Student { Name = "Roshan" },
            new Student { Name = "Elina" },
            new Student { Name = "Manish" },
            new Student { Name = "Isha" }
        };

        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("Sorted Students:");
        foreach (var s in sortedStudents)
            Console.WriteLine(s.Name);


        // 1. AGGREGATION OPERATOR (Cashier Sales)
        // -------------------------------------------------------------
        List<Cashier> salesList = new List<Cashier>
        {
            new Cashier { CashierName = "Riya", SalesAmount = 15000 },
            new Cashier { CashierName = "Sujal", SalesAmount = 18000 },
            new Cashier { CashierName = "Aayush", SalesAmount = 12000 },
            new Cashier { CashierName = "Elisa", SalesAmount = 21000 }
        };

        int totalCashiers = salesList.Count();
        double totalSales = salesList.Sum(s => s.SalesAmount);
        double highestSale = salesList.Max(s => s.SalesAmount);
        double lowestSale = salesList.Min(s => s.SalesAmount);
        double averageSale = salesList.Average(s => s.SalesAmount);

        Console.WriteLine("AGGREGATION RESULTS:");
        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Highest Sale: {highestSale}");
        Console.WriteLine($"Lowest Sale: {lowestSale}");
        Console.WriteLine($"Average Sale: {averageSale}\n");


        // 2. QUANTIFIER OPERATORS (Any / All)
        // -------------------------------------------------------------
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Bibek", Age = 20 },
            new Applicant { Name = "Roshan", Age = 17 },
            new Applicant { Name = "Sita", Age = 22 },
            new Applicant { Name = "Kiran", Age = 16 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("QUANTIFIER RESULTS:");
        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"Are all applicants above 16? {allAbove16}\n");


        // 3. ELEMENT OPERATORS (First, Last, FirstOrDefault)
        // -------------------------------------------------------------
        List<Music> songs = new List<Music>
        {
            new Music { Title = "Song A", DurationInSeconds = 180 },
            new Music { Title = "Song B", DurationInSeconds = 230 },
            new Music { Title = "Song C", DurationInSeconds = 260 },
            new Music { Title = "Song D", DurationInSeconds = 400 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240);   // 4 min = 240 sec
        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600);

        Console.WriteLine("ELEMENT OPERATOR RESULTS:");
        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First Song above 4 minutes: {firstAbove4Min.Title}");

        if (firstAbove10Min == null)
            Console.WriteLine("No song longer than 10 minutes (safe result: null)");
        else
            Console.WriteLine($"Song above 10 minutes: {firstAbove10Min.Title}");
    
        List<TourBooking> tours = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Riya", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
            new TourBooking { CustomerName = "Sujal", Destination = "Bangkok", Price = 25000, DurationInDay = 5, IsInternational = true },
            new TourBooking { CustomerName = "Aayush", Destination = "Ilam", Price = 12000, DurationInDay = 4, IsInternational = false },
            new TourBooking { CustomerName = "Elina", Destination = "Dubai", Price = 45000, DurationInDay = 7, IsInternational = true }
        };

        // Step 1: FILTER the list (Your previous conditions)
        var filteredTours = tours.Where(t => t.Price > 10000 && t.DurationInDay > 4);

        // Step 2: TRANSFORM (PROJECT) the list into new structure
        var transformedList = filteredTours
            .Select(t => new
            {
                t.CustomerName,
                t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                t.Price
            })

            // Step 3: SORT: Domestic (first) then International
            // Then sort inside category by price
            .OrderBy(t => t.Category)    // Domestic comes before International alphabetically
            .ThenBy(t => t.Price)
            .ToList();

        // Step 4: DISPLAY RESULTS
        Console.WriteLine("=== TRANSFORMED & SORTED TOUR LIST ===\n");
        foreach (var item in transformedList)
        {
            Console.WriteLine($"Customer: {item.CustomerName}");
            Console.WriteLine($"Destination: {item.Destination}");
            Console.WriteLine($"Category: {item.Category}");
            Console.WriteLine($"Price: Rs. {item.Price}");
            Console.WriteLine("-----------------------------------");
        }
    }
}

