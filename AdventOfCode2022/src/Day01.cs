namespace AdventOfCode2022;

public record Elf(
  List<int> food
);

public class Day01 : Solution
{
  private IEnumerable<Elf> elves;

  public override Task ParseInput(string input)
  {
    elves = input.Split(Environment.NewLine)
      .Aggregate(new List<Elf> { new Elf(food: new List<int>()) }, (acc, line) =>
      {
        if (string.IsNullOrWhiteSpace(line))
        {
          acc.Add(new Elf(new List<int>()));
        }
        else
        {
          var calories = int.Parse(line);
          acc[^1].food.Add(calories);
        }
        return acc;
      })
      .AsReadOnly();
    return Task.CompletedTask;
  }

  public override async Task<string> Part1() => elves.Max(elf => elf.food.Sum()).ToString();

  public override Task<string> Part2()
  {
    throw new System.NotImplementedException();
  }
}