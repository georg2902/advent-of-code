namespace AoC2025.Day2;

public static class DayTwo
{
    public static void Execute()
    {
        var testInput = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";
        var input = "";
        var ranges = input.Split(",");
        long sum = 0;
        foreach (var range in ranges)
        {
            var elements = range.Split("-");
            var startId = Int64.Parse(elements[0]);
            var endId = Int64.Parse(elements[1]);
            for (Int64 id = startId; id <= endId; id++)
            {
                sum += Validate(id);
            }
        }
        Console.WriteLine($"Invalid ID Sum: {sum}");
    }

    private static Int64 Validate(Int64 id)
    {
        var idAsString = id.ToString();
        var length = idAsString.Length;
        if (length % 2 != 0)
        {
            // is valid id
            return 0;
        }

        var middleIndex = length / 2;
        var firstHalf = idAsString[..middleIndex];
        var secondHalf = idAsString[middleIndex..];
        //Console.WriteLine($"First Half: {firstHalf}");
        //Console.WriteLine($"2nd Half: {secondHalf}");
        if (firstHalf == secondHalf)
        {
            // is invalid
            return id;
        }
        
        return 0;
    }
}