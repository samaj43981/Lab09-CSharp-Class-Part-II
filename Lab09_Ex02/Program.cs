Person.name = "joaj";
Console.WriteLine(Person.GetName());

public static class Person
{
    public static string? name;

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}