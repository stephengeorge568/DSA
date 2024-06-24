using DSA.Src.Algos;

namespace DSA.Tests.Algos;

public class SortsTests
{
    [Fact]
    public void BubbleSortTest()
    {
        var input = new int[]{3, 2, 1, 2, 6, 0, 21, 4, 8, 1, 4};
        var sorted = Sorts.BubbleSort(input);
        Console.WriteLine(sorted);
    }
}
