public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Paso 1: Crear un arreglo del tamaño que se necesita
        double[] multiples = new double[length];

        // Paso 2: Usar un bucle para rellenar el arreglo con los múltiplos
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // Ejemplo: 3 * 1, 3 * 2, etc.
        }

        // Paso 3: Devolver el arreglo ya lleno
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Paso 1: Ajustar por si el número de rotaciones es igual o mayor al tamaño
        amount = amount % data.Count;

        // Paso 2: Sacar la parte que irá al inicio
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Paso 3: Sacar la parte que quedará al final
        List<int> head = data.GetRange(0, data.Count - amount);

        // Paso 4: Limpiar la lista original y unir las dos partes en orden
        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
