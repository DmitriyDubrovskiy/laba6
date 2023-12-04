class Program
{
    static void Main()
    {
        // Приклад використання
        int num1 = 5, num2 = 10;
        double[] array1 = { 1.5, 2.5, 3.5 };
        double[] array2 = { 0.5, 1.5, 2.5 };
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        Console.WriteLine($"Addition of numbers: {MathOperations.Add(num1, num2)}");

        Console.WriteLine("Addition of arrays:");
        foreach (var item in MathOperations.Add(array1, array2))
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Addition of matrices:");
        var resultMatrix = MathOperations.Add(matrix1, matrix2);
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
