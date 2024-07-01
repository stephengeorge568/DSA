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

    public static int[] InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i;
            while (j > 0 && arr[j] < arr[j - 1])
            {
                Swap(ref arr[j], ref arr[j - 1]);
                j--;
            }
        }
        return arr;
    }

    public static int[] SelectionSort(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int biggestIndex = 0;
            for (int j = 0; j <= i; j++)
            {
                if (arr[j] > arr[biggestIndex])
                {
                    biggestIndex = j;
                }
            }
            Swap(ref arr[i], ref arr[biggestIndex]);
        }
        return arr;
    }

    private static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
