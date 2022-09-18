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
}