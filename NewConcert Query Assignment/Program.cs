using NewConcert_Query_Assignment;
using System.Text.Json;


string concertData = File.ReadAllText("C:\\Users\\deltagaren\\source\\repos\\Concert Query Assignment\\Concert Query Assignment\\concert_data.json");
List<Concert> concerts = JsonSerializer.Deserialize<List<Concert>>(concertData);


// 1.Return a new List<Concert> ordered by the Date value, going from the present date. 
List<Concert> orderedByDateValue = concerts
    .Where(x => x.Date >= DateTime.Now)
    .OrderBy(x => x.Date)
    .ToList();

Console.WriteLine("\n1.Return a new List<Concert> ordered by the Date value, going from the present date:\n");

foreach (var concert in orderedByDateValue)
{
    Console.WriteLine($"Concert Number: " + concert.Id.ToString() + " begins at " +
    concert.Date.ToString("yyyy-MMM-dd"));
}

// 2. Return a new List<Concert> with all concerts of a ReducedVenue (true).
List<Concert> ReducedVenueTrue = concerts
     .OrderBy(x => x.ReducedVenue)
     .ToList();

Console.WriteLine("\n2.Return a new List<Concert> with all concerts of a ReducedVenue (true):\n");

foreach (var concert in ReducedVenueTrue)
{
    bool reducedVenue = concert.ReducedVenue;
    if (reducedVenue)
    {
        Console.WriteLine($"Concert Number: " + concert.Id.ToString() + ", has Reduced Venue TRUE");
    }
}


// 3.Return a new List<Concert> with all concerts during 2024.
List<Concert> concerts2024 = concerts
     .Where(x => x.Date >= x.StartDate && x.Date<= x.EndDate)
     .OrderBy(x => x.Date)
     .ToList();
Console.WriteLine("\n3.Return a new List<Concert> with all concerts during 2024:\n");

foreach (var concert in concerts2024)
{
        Console.WriteLine($"Concert Number: " + concert.Id.ToString() + ", takes place on: " + concert.Date);
}


//4. Return a new List<Concert> with the five biggest projected sales figures (the FullCapacitySales value).
List<Concert> FullCapacitySales = concerts
    .OrderByDescending(x => x.FullCapacitySales)
    .Take(5)
    .ToList();

Console.WriteLine("\n4.Return a new List<Concert> with the five biggest projected sales figures (the FullCapacitySales value):\n");

foreach (var concert in FullCapacitySales)
{
    int n = concert.FullCapacitySales;
    Console.WriteLine($"Concert Number: " + concert.Id.ToString() + ", has a Full Capacity Sales of: " + concert.FullCapacitySales);
}

//5. Return a new List<Concert> with all concerts taking place on a Friday. The Date (because it is of DateTime)
//   has a property called DayOfWeek. There is also an enumeration called the same thing, DayOfWeek.
List<Concert> FridayConcerts = concerts
    .Where(x => x.Date.DayOfWeek == DayOfWeek.Friday)
    .ToList();

Console.WriteLine("\n5.Return a new List<Concert> with all concerts taking place on a Friday:\n");

foreach (var concert in FridayConcerts)
{
    Console.WriteLine($"Concert Number: " + concert.Id.ToString() + ", takes place on: " + concert.Date.DayOfWeek);
}