public class Apple : Fruit
{
    public int NumberOfSeeds { get; set; }

    public string DescribeMe => $"Hi. My name is { Name }, I'm color { Color } and I have { NumberOfSeeds } seed(s).";
}