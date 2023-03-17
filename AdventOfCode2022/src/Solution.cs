namespace AdventOfCode2022;

public abstract class Solution
{
  public abstract Task ParseInput(string input);
  public abstract Task<string> Part1();
  public abstract Task<string> Part2();
}