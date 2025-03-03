namespace ConsoleApp;

public abstract class PersonBase
{
    public string Name { get; set; }

    protected PersonBase(string name)
    {
        Name = name;
    }

    public abstract string GetRole();

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Role: {GetRole()}");
    }
}
