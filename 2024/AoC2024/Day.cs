using System.Reflection;

namespace _2024;

public abstract class Day
{
    private bool IsTestInput { get; set; }

    protected Day(string input)
    {
        IsTestInput = true;
        Input = input;
    }

    protected Day()
    {
        var space = GetType().Namespace?.Split(".").Last();
        var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
            $"{space}/input.txt");
        var reader = new StreamReader(path);
        Input = reader.ReadToEnd();
    }

    public string Input { get; set; }

    public void Main()
    {
        var type = IsTestInput ? "Test Input" : string.Empty;
        Console.WriteLine($"Day {GetType().Name} {type}");
    }

    public abstract void Solve();
}