using DSA.Src.Algos;

namespace DSA.Tests.Algos;

public class SearchesTests
{
    [Fact]
    public void BinarySearchTest()
    {
        var input = new int[]{0,1,2,3,4,5,6,7,9};
        Assert.Throws<InvalidOperationException>(() => Searches.BinarySearch(input, 100));
        Assert.Throws<InvalidOperationException>(() => Searches.BinarySearch(input, -100));
        Assert.Throws<InvalidOperationException>(() => Searches.BinarySearch(input, 8));
        Assert.Equal(0, Searches.BinarySearch(input, 0));
        Assert.Equal(1, Searches.BinarySearch(input, 1));
        Assert.Equal(2, Searches.BinarySearch(input, 2));
        Assert.Equal(3, Searches.BinarySearch(input, 3));
        Assert.Equal(4, Searches.BinarySearch(input, 4));
        Assert.Equal(5, Searches.BinarySearch(input, 5));
        Assert.Equal(6, Searches.BinarySearch(input, 6));
        Assert.Equal(7, Searches.BinarySearch(input, 7));
        Assert.Equal(8, Searches.BinarySearch(input, 9));

        var input2 = new int[]{0};
        Assert.Equal(0, Searches.BinarySearch(input2, 0));

        var input3 = new int[]{};
        Assert.Throws<InvalidOperationException>(() => Searches.BinarySearch(input3, 100));
    }
}
