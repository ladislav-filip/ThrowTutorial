// See https://aka.ms/new-console-template for more information
using ThrowTutorial;

Console.Clear();
Console.WriteLine();
Console.WriteLine("Start...");
Console.WriteLine();

try
{
    var date = new DateTime(2110, 10, 10);
    ThrowStyle.Run(date);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.GetType()}");
    Console.WriteLine("\t" + e.Message);
}

Console.WriteLine("Finnish");