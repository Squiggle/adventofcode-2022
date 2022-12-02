using System.IO;
using System.Linq;
using System.Collections.Generic;

var lines = File.ReadAllLines("input.txt");
var elves = new List<int>();
var currentElfCalories = 0;

// line-by-line approach
// creating a collection of all elves
foreach (var line in lines) {
    if (string.IsNullOrWhiteSpace(line)) {
        elves.Add(currentElfCalories);
        currentElfCalories = 0;
    }
    else {
        currentElfCalories += Convert.ToInt32(line);
    }
}
elves.Add(currentElfCalories);

var sturdiestElf = elves.Max();
Console.WriteLine($"Sturdiest elf: {sturdiestElf}");

var topThree = elves.OrderByDescending(i => i).Take(3).ToList();
Console.WriteLine($"Top three elves: {topThree[0]}, {topThree[1]}, {topThree[2]}");
Console.WriteLine($"Top three total: {topThree.Sum()}");
