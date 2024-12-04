using System.Text.RegularExpressions;

namespace _2024.DayThree;

public class Day3 : Day
{
    public Day3(string input) : base(input)
    {
    }

    public Day3()
    {
    }

    protected override void Solve()
    {
        PartOne();
        PartTwo();
    }

    private void PartOne()
    {
        var rows = Input.Split("\n");
        var pattern = new Regex("(mul\\((\\d{1,3}),(\\d{1,3})\\))");
        var sum = 0;
        foreach (var row in rows)
        {
            var matches = pattern.Matches(row);
            foreach (Match match in matches)
            {
                var a = int.Parse(match.Groups[2].Value);
                var b = int.Parse(match.Groups[3].Value);
                var mul = a * b;
                sum += mul;
            }
        }

        Console.WriteLine("Solution Part 1: " + sum);
    }

    private void PartTwo()
    {
        var rows = Input;
        var pattern = new Regex("(mul\\((\\d{1,3}),(\\d{1,3})\\))");
        var doPattern = new Regex("do\\(\\)");
        var dontPattern = new Regex("don't\\(\\)");
        var sum = 0;
        var matches = pattern.Matches(rows).ToDictionary(x => x.Index, x => x);
        var doMatches = doPattern.Matches(rows).ToDictionary(x => x.Index, x => x);
        var dontMatches = dontPattern.Matches(rows).ToDictionary(x => x.Index, x => x);
        var combined = matches.Values.Concat(doMatches.Values).Concat(dontMatches.Values).OrderBy(x => x.Index);
        var multiply = true;
        foreach (Match match in combined)
        {
            if (match.Value.Contains("do()"))
            {
                multiply = true;
                continue;
            }

            if (match.Value.Contains("don't()"))
            {
                multiply = false;
                continue;
            }

            if (match.Value.Contains("mul") && multiply)
            {
                var a = int.Parse(match.Groups[2].Value);
                var b = int.Parse(match.Groups[3].Value);
                var mul = a * b;
                sum += mul;
            }
        }

        Console.WriteLine("Solution Part 2: " + sum);
    }
}