using Throw;

namespace ThrowTutorial;

public static class ThrowStyle
{
    public static void Run(string? name)
    {
        name.ThrowIfNull(() => new ApplicationException("My custom exception with my message"))
            .Throw<FormatException>()
            .IfLongerThan(4)
            .Throw("My text for exception")
            .IfContains("tr");
        
        Console.WriteLine($"Parameter is correctly. Value is '{name}'");
    }

    public static void Run(Employee? employee)
    {
        employee.ThrowIfNull()
            //.Throw(() => new ApplicationException("Age is greather than 100"))
            .IfGreaterThan(s => s.Age, 100)
            //.Throw(paramName => new CustomException(paramName, "Unknown gender must has age greater than 14"))
            //.IfTrue(s => s.Age < 15 && s.Gender == Gender.Unknown)
            //.Throw() // revert implicit exception
            //.IfNotHttps(s => s.WebUrl)
            // .IfOutOfRange(s => s.Age, 10, 90)  // ArgumentOutOfRangeException
            .IfEmpty(s => s.Cars)  // neexistuje něco jako IfNullOrEmpty
            .IfContains(s => s.Cars, "BMW")
            ;

        Console.WriteLine(employee);
    }

    public static void Run(DateTime date)
    {
        date
            .Throw()
            .IfThisCentury();
    }

    public static void Run(IEnumerable<string> cars)
    {
        cars
            .Throw()
            .IfAcceptedCars();
    }
}