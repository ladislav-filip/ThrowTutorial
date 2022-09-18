namespace ThrowTutorial;

public static class StandardStyle
{
    public static void Run(string? name)
    {
        if (name == null)
        {
            throw new ArgumentNullException($"Parameter {nameof(name)} is NULL");
        }

        if (name.Length > 4)
        {
            throw new ArgumentException($"Parameter {nameof(name)} is greater than 4");
        }

        if (name.Contains("tr"))
        {
            throw new ArgumentException($"Parameter {nameof(name)} is contain 'tr'");
        }
        
        Console.WriteLine($"Parameter is correctly. Value is '{name}'");
    }
}