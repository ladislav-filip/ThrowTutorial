namespace ThrowTutorial;

public sealed record Employee(
    string Name,
    string Surname,
    byte Age,
    Gender Gender,
    Uri WebUrl,
    List<string>? Cars = null
)
{
    public override string ToString()
    {
        return $"{Name} {Surname}\r\nAge: {Age}\r\nGender: {Gender}\r\nUrl: {WebUrl}";
    }
};