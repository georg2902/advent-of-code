namespace _2024.DayOne;

public class Day1 : Day
{
    public Day1(string input) : base(input)
    {
    }

    public Day1()
    {
        
    }

    public new void Main()
    {
        base.Main();
        Solve();
    }
    
    public override void Solve()
    {
        PartOne();
        PartTwo();
    }

    public void PartOne()
    {
        
        // Console.WriteLine(Input);
        var pairs = Input.Split("\n").ToList().Select(p =>
        {
            var values = p.Split("   ");
            return new { Left = values[0], Right = values[1] };
        });
        var leftList = new List<int>();
        var rightList = new List<int>();
        foreach (var pair in pairs)
        {
            leftList.Add(int.Parse(pair.Left));
            rightList.Add(int.Parse(pair.Right));
        }

        leftList = leftList.Order().ToList();
        rightList = rightList.Order().ToList();

        var distanceSum = 0;
        for (int i = 0; i < leftList.Count; i++)
        {
            var left = leftList[i];
            var right = rightList[i];
            var distance = int.Abs(left - right);
            distanceSum += distance;
        }
        
        Console.WriteLine($"Solution Part 1: {distanceSum}");
    }
    
    public void PartTwo()
    {
        
        // Console.WriteLine(Input);
        var pairs = Input.Split("\n").ToList().Select(p =>
        {
            var values = p.Split("   ");
            return new { Left = values[0], Right = values[1] };
        });
        var leftList = new List<int>();
        var rightList = new List<int>();
        foreach (var pair in pairs)
        {
            leftList.Add(int.Parse(pair.Left));
            rightList.Add(int.Parse(pair.Right));
        }

        leftList = leftList.Order().ToList();
        rightList = rightList.Order().ToList();

        var similarityCountSum = 0;
        for (int i = 0; i < leftList.Count; i++)
        {
            var left = leftList[i];
            var right = rightList.Count(x => x == left);
            var similarityCount = left * right;
            similarityCountSum += similarityCount;
        }
        
        Console.WriteLine($"Solution Part 2: {similarityCountSum}");
    }
}