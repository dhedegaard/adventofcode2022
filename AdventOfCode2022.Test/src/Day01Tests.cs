namespace AdventOfCode2022.Test;

[TestClass]
public class Day01Tests
{
  [TestMethod]
  public async Task TestPart1Example()
  {
    var input = await File.ReadAllTextAsync(Path.Join(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "examples", "day01.txt"));
    var day01 = new Day01();
    await day01.ParseInput(input);

    var result = await day01.Part1();

    Assert.AreEqual("24000", result);
  }

  [TestMethod]
  public async Task TestPart1()
  {
    var input = await File.ReadAllTextAsync(Path.Join(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "inputs", "day01.txt"));
    var day01 = new Day01();
    await day01.ParseInput(input);

    var result = await day01.Part1();

    Assert.AreEqual("70764", result);
  }
}