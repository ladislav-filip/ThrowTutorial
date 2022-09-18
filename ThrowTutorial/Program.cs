// See https://aka.ms/new-console-template for more information
using ThrowTutorial;

Console.Clear();
Console.WriteLine();
Console.WriteLine("Start...");
Console.WriteLine();

try
{
    // string? name = "Petr";
    var employee = new Employee(
        Name: "John", 
        Surname: "Rambo", 
        Age: 33, 
        Gender.Male, 
        WebUrl: new Uri("http://example.com")
        );

    ThrowStyle.Run(employee);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.GetType()}");
    Console.WriteLine("\t" + e.Message);
}

Console.WriteLine("Finnish");