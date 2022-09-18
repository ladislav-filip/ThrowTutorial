// See https://aka.ms/new-console-template for more information

using Throw;
using ThrowTutorial;

Console.WriteLine();
Console.WriteLine("Start...");
Console.WriteLine();

try
{
    var name = "Peter";
    
    //StandardStyle.Run(name);
    
    ThrowStyle.Run(name);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.GetType()}");
    Console.WriteLine("\t" + e.Message);
}

Console.WriteLine("Finnish");