public class Program
{
    public static void BinarySearch(int[] array, int target)
    {
        int low = 0; // first element

        int high = array.Length -1; // last element

        if (target > array[high] || target < array[low])
        {
            Console.WriteLine("Out Of Range !");
        }
        else
        {
            while (low <= high)
            {
                int middle = low + (high - low) / 2; // index of middle element

                if (array[middle] == target)
                {
                    Console.WriteLine($"Element Value : {array[middle]} & Element Index : {middle}");
                    return;
                }
                else if (array[middle] > target)
                {
                    high = middle - 1;
                }
                else if (array[middle] < target)
                {
                    low = middle + 1;
                }
            }
        }
    }

    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 15 };

        BinarySearch(array, 8);
        BinarySearch(array, 1);
        BinarySearch(array, 15);
        BinarySearch(array, 6);
        BinarySearch(array, 22);
        BinarySearch(array, 0);
    }
}
