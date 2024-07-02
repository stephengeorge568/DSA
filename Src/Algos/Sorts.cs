namespace DSA.Src.Algos;

public static class Sorts
{
    // Other implementations use an outer for loop. This forces n number of outer loops. Flag method below limits outer loop
    // iterations when it can. Better?
    // n^2
    // compare adjacent elements. if unsorted, swap. iterate this process over list several times
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

    // left hand side sorted. right unsorted. move from left to right
    // putting element into correct sorted position of left hand side.
    // shift elements down as needed.
    // n^2
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

    // n^2
    // right hand side sorted. left unsorted. iterate over all on left to find biggest,
    // then put in right side.
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

    // Heaps follow 2 rules. parent nodes greater or equal to children. Binary tree, fills from left to right
    // all layers except last layer must be completed filled in. and only right side of that row can be partially empty
    public static int[] HeapSort(int[] arr)
    {
        if (arr.Length == 0)
        {
            return arr;
        }

        // Make arr a max heap. The sorting process relys on this being true and largest element being at top.
        for (int i = arr.Length / 2 - 1; i >=0; i--)
        {
            Heapify(arr, i, 0);
        }

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Swap(ref arr[0], ref arr[i]);
            Heapify(arr, i, 0);
        }
        return arr;
    }

    private static void Heapify(int[] arr, int size, int index)
    {
        var largest = index;
        // if array is visualized as a heap/bin tree, arr position x can be transformed into the left-right tree position with this formula
        var left = 2 * index + 1;
        var right = 2 * index + 2;
        if (left < arr.Length && arr[left] > arr[largest])
        {
            largest = left;
        }

        if (right < arr.Length && arr[right] > arr[largest])
        {
            largest = right;
        }

        if (largest != index)
        {
            // shift the larger child up and swap with parent.
            Swap(ref arr[index], ref arr[largest]);
            Heapify(arr, size, largest);
        }
    }

    private static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
