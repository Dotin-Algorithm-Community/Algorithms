public void SelectionSort()
{
    var arrayLength = NumArray.Length;

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
