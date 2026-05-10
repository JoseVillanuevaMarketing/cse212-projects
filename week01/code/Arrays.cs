public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1:
        // Create a new array with the size equal to the requested length.

        double[] result = new double[length];

        // Step 2:
        // Use a loop to fill the array with multiples of the number.
        // The first value will be number * 1.
        // The second value will be number * 2.
        // Continue until the array is full.

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 3:
        // Return the completed array.

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1:
        // Find the position where the list should be split.
        // Example:
        // If the list has 9 items and amount is 3,
        // then splitIndex will be 6.

        int splitIndex = data.Count - amount;

        // Step 2:
        // Get the portion from the split index to the end.
        // These values will move to the front.

        List<int> rightSide = data.GetRange(splitIndex, amount);

        // Step 3:
        // Get the portion from the beginning to the split index.
        // These values will move to the back.

        List<int> leftSide = data.GetRange(0, splitIndex);

        // Step 4:
        // Clear the original list.

        data.Clear();

        // Step 5:
        // Add the rotated values back into the list.

        data.AddRange(rightSide);
        data.AddRange(leftSide);
    }
}
