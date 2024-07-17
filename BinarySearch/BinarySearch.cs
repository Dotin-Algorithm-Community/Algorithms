public class Program
{
    public static void BinarySearch(int[] array, int target)
    {
        int low = array[0];
        int high = array[^1];

        if (target > high || target < low)
        {
            Console.WriteLine("Out Of range !");
        }
        else
        {
            while (low <= high)
            {
                int middleElement = (low + high) / 2;

                if (middleElement == target)
                {
                    Console.WriteLine($"Found {middleElement}!");
                    break;
                }
                else if (middleElement < target)
                {
                    low = middleElement + 1;
                }
                else if (middleElement > target)
                {
                    high = middleElement - 1;
                }
            }
        }

    }
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array1 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //BinarySearch(array, 8);
        //BinarySearch(array1, 11);
        BinarySearch(array1, 8);

    }

}