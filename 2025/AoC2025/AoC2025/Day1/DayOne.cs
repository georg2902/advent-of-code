namespace AoC2025.Day1;

public static class DayOne
{
   private const int StartPoint = 50;
   public static void Execute()
   {
      Console.WriteLine("Day1");
      var testInput = "L68\nL30\nR48\nL5\nR60\nL55\nL1\nL99\nR14\nL82";
      var testSolution = Solve(testInput);
      var input = "";
      var solution = Solve(input);
      Console.WriteLine($"TestSolution: {testSolution}");
      Console.WriteLine($"Solution: {solution}");
   }

   private static int Solve(string input)
   {
      var instructions = input.Split("\n");
      var zeroCounter = 0;
      var current = StartPoint;
      foreach (var instruction in instructions)
      {
         Console.WriteLine(instruction);
         var direction = instruction[0];
         var value = int.Parse(instruction[1..]);
         if (value.ToString().Length > 2)
         {
            value = int.Parse(value.ToString()[^2..]);
            Console.WriteLine(value);
         }
         if (direction == 'L')
         {
            current -= value;
            if (current < 0)
            {
               current = 100 - Math.Abs(current);
            }
            else if(current > 99)
            {
               current = current - 100;
            }

         } else if (direction == 'R')
         {
            current += value;
            if (current > 99)
            {
               current = current - 100;
            }
         }

         if (current == 0)
         {
            zeroCounter++;
         }
      }

      return zeroCounter;
   }
}