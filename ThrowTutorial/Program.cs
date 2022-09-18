// See https://aka.ms/new-console-template for more information
using ThrowTutorial;

Console.Clear();
Console.WriteLine();
Console.WriteLine("Start...");
Console.WriteLine();

try
{
    string? name = "Petr";
    
    ThrowStyle.Run(name);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.GetType()}");
    Console.WriteLine("\t" + e.Message);
}

Console.WriteLine("Finnish");