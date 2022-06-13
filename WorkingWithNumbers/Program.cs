using System.Numerics;
using static System.Console;


// p.318 Numbers
WriteLine("Worlking with large integers:");
WriteLine("------------------------------");

ulong big = ulong.MaxValue;
WriteLine($"{big,40:N0}"); // 40 means right align 40 caracters

BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");

WriteLine($"{bigger,40:N0}");

WriteLine("Working with complex numbers;");
Complex c1 = new(real: 4, imaginary: 2);
Complex c2 = new(real: 3, imaginary: 7);
Complex c3 = c1 + c2;

// output using default ToStrint implementation
WriteLine($"{c1} added to {c2} is {c3}");

// output using custom format
WriteLine("{0} + {1}i aded to {2} + {3}i is {4} + {5}i",
    c1.Real, c1.Imaginary,
    c2.Real, c2.Imaginary,
    c3.Real, c3.Imaginary);


// p.320 Text
string city = "London";
WriteLine($"{city} is {city.Length} caracters long.");

WriteLine($"First char is {city[0]} and third is {city[2]}");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";

string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array");
foreach(string c in citiesArray)
{
    WriteLine(c);
}

string fullName = "Alan Jones";
int indexOfTheSpace = fullName.IndexOf(' '); // it returns 4

string firstName = fullName.Substring(startIndex:0, length:indexOfTheSpace); // starts at 0 for length of 4
string lastName = fullName.Substring(startIndex:indexOfTheSpace+1); // starts at 4 + 1 till the end

WriteLine($"Original:{fullName}");
WriteLine($"Swapped : {lastName}, {firstName}");

string company = "Microsoft";
bool startsWithM = company.StartsWith("M");
bool containsN = company.Contains("N");
WriteLine($"Text: {company} starts with M: {startsWithM}, contains an N: {containsN}");

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

// p.324 Building strings efficiently
// avoid String.Cancat or + operator because these methods create a completelu new string in memory

WriteLine("Earliest date/Time value is {0}", arg0 : DateTime.MinValue);
WriteLine("UNIX epoch date/Time value is {0}", arg0 : DateTime.UnixEpoch);
WriteLine("Date/Time value Now is {0}", arg0 : DateTime.Today);

DateTime christmas = new(year: 2021, month:12, day:25);
WriteLine(christmas);
WriteLine("{0:dddd, dd MMMM yyyy}", arg0: christmas);
WriteLine("Christmas is the day {0} of the year", arg0: christmas.DayOfYear);
WriteLine("Christmas {0} is on a {1}", arg0: christmas.Year, arg1: christmas.DayOfWeek);

DateTime beforeXmas = christmas.Subtract(TimeSpan.FromDays(12));
DateTime afterXmas = christmas.AddDays(12);
WriteLine($"12 days before Christmas is {beforeXmas}");
WriteLine($"12 days after Christmas is {afterXmas}");

TimeSpan untilChristmas = christmas - DateTime.Now;

WriteLine("There are {0} days and {1} hours until Christmas",
    arg0: untilChristmas.Days,
    arg1: untilChristmas.Hours);

WriteLine("There are {0:N0} hours until Christmas",
    arg0: untilChristmas.TotalHours);
   