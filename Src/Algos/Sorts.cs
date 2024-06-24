namespace DSA.Src.Algos;

public static class Sorts
{
    // Other implementations use an outer for loop. This forces n number of outer loops. Flag method below limits outer loop
    // iterations when it can. Better?
    public static int[] BubbleSort(int[] arr)
    {
        bool hasSwapped;
        do
        {
            hasSwapped = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(ref arr[i], ref arr[i + 1]);
                    hasSwapped = true;
                } 
            }
        } while (hasSwapped);
        
        return arr;
    }

    private static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
