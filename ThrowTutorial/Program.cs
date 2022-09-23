// See https://aka.ms/new-console-template for more information
using ThrowTutorial;

Console.Clear();
Console.WriteLine();
Console.WriteLine("Start...");
Console.WriteLine();

try
{
    var cars = new[] { "BMW", "Skoda", "Trabant" };
    var date = new DateTime(2110, 10, 10);
    
    // ThrowStyle.Run(date);
    ThrowStyle.Run(cars);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.GetType()}");
    Console.WriteLine("\t" + e.Message);
}

Console.WriteLine("Finnish");