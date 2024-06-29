namespace DSA.Src.Algos;

public static class Searches
{
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        // when left/right pass we know we've condensed all the way down, so stop
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (arr[middle] == target)
            {
                return middle;
            }
            else if (arr[middle] < target)
            {
                // look higher
                left = middle + 1;
            }
            else
            {
                // look lower
                right = middle - 1;
            }
        }
        throw new InvalidOperationException("Target not found");
    }
}
