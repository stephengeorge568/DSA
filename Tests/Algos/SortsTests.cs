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

    [Fact]
    public void InsertionSortTest()
    {
        var input = new int[]{3, 2, 1, 2, 6, 0, 21, 4, 8, 1, 4};
        var sorted = Sorts.InsertionSort(input);
        Console.WriteLine(sorted);
    }

    [Fact]
    public void SelectionSortTest()
    {
        var input = new int[]{3, 2, 1, 2, 6, 0, 21, 4, 8, 1, 4};
        var sorted = Sorts.SelectionSort(input);
        Console.WriteLine(sorted);
    }

    [Fact]
    public void HeapSortTest()
    {
        var input = new int[]{3, 2, 1, 21, 2, 6};
        var sorted = Sorts.HeapSort(input);
        Console.WriteLine(sorted);
    }
}
