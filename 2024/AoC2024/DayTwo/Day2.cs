namespace _2024.DayTwo;

public class Day2 : Day
{
    public Day2(string input) : base(input)
    {
    }

    public Day2()
    {
    }

    protected override void Solve()
    {
        PartOne();
        PartTwo();
    }

    private void PartOne()
    {
        var safeCount = 0;
        var rows = Input.Split("\n").Select(x => x.Split(" ")).ToList();
        foreach (var values in rows)
        {
            if (IsSafe(values) is false)
            {
                continue;
            }

            safeCount++;
        }

        Console.WriteLine($"Solution Part 1: {safeCount}");
    }

    private void PartTwo()
    {
        var safeCount = 0;
        var rows = Input.Split("\n").Select(x => x.Split(" ")).ToList();
        foreach (var values in rows)
        {
            if (IsSafe(values) is false)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    var damped = values.ToList();
                    damped.RemoveAt(i);
                    if (IsSafe(damped.ToArray()) is false)
                    {
                        continue;
                    }

                    safeCount++;
                    break;
                }
            }
            else
            {
                safeCount++;
            }
        }

        Console.WriteLine($"Solution Part 2: {safeCount}");
    }

    private bool IsSafe(string[] values)
    {
        var inc = false;
        var dec = false;
        for (int i = 0; i < values.Length; i++)
        {
            for (int j = 1; j < values.Length; j++)
            {
                var a = int.Parse(values[i]);
                var b = int.Parse(values[j]);
                var distance = int.Abs(a - b);
                if (distance is 0 or > 3)
                {
                    return false;
                }

                if (b > a)
                {
                    inc = true;
                }
                else
                {
                    dec = true;
                }

                i++;
            }
        }

        if (inc && dec)
        {
            return false;
        }

        return true;
    }
}