public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>Array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array with the specified length
        double[] multiples = new double[length];

        // Step 2: Use a loop to fill the array with multiples
        // For example: 3 * 1, 3 * 2, 3 * 3, etc.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the filled array
        return multiples;
    }

    /// <summary>
    /// Rotates the list 'data' to the right by the given 'amount'.
    /// For example, if data = {1,2,3,4,5,6,7,8,9} and amount = 3,
    /// the result should be {7,8,9,1,2,3,4,5,6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Handle cases where amount >= data.Count
        amount = amount % data.Count;

        // Step 2: Get the last 'amount' elements (the part that will move to the front)
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Step 3: Get the remaining elements (the part that stays at the back)
        List<int> head = data.GetRange(0, data.Count - amount);

        // Step 4: Clear the original list and add the tail + head
        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
