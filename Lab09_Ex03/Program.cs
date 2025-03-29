public static class Person
{
    public static string? name;

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

public class Student
{
    public string? name;

    public string GetName()
    {
        return $"Hello from {name}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person.name = "samaj";
        System.Console.WriteLine(Person.GetName());

        Student student = new Student();
        student.name = "thanakrit";
        System.Console.WriteLine(student.GetName());
    }
}