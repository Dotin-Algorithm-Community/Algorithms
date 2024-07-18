class public Program
{

    public static void SelectionSort(int[] array)
    {
        var arrayLength = array.Length;
    
        for (int i = 0; i < arrayLength - 1; i++)
        {
            var minimum = i;
    
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (NumArray[j] < NumArray[minimum])
                {
                    minimum = j;
                }
            }
    
            var temp = NumArray[minimum];
            NumArray[minimum] = NumArray[i];
            NumArray[i] = temp;
        }
    }

    public static void Main()
    {
        int[] array = {3,4,12,52,74,3,72,41};
        
        SelectionSort(array);

        foreach(var item in array)
        {
            Console.WriteLine(item)
        }
    }
}

