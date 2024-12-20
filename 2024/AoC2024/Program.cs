﻿// See https://aka.ms/new-console-template for more information

using _2024.DayOne;
using _2024.DayThree;
using _2024.DayTwo;

Console.WriteLine("AoC 2024");
new Day1("3   4\n4   3\n2   5\n1   3\n3   9\n3   3").Main();
new Day1().Main();
new Day2("7 6 4 2 1\n1 2 7 8 9\n9 7 6 2 1\n1 3 2 4 5\n8 6 4 4 1\n1 3 6 7 9").Main();
new Day2().Main();
new Day3("xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))").Main();
new Day3("xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))").Main();
new Day3().Main();
