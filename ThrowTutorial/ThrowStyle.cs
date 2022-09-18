using Throw;

namespace ThrowTutorial;

public static class ThrowStyle
{
    public static void Run(string? name)
    {
        name.ThrowIfNull()
            .IfLongerThan(4)
            .IfContains("tr");
        
        Console.WriteLine($"Parameter is correctly. Value is '{name}'");
    }
}