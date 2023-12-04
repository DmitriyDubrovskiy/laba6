using System;

public class MathOperations
{
    // Перевантажений метод додавання для чисел
    public static T Add<T>(T a, T b)
    {
        dynamic dynamicA = a;
        dynamic dynamicB = b;
        return dynamicA + dynamicB;
    }

    // Перевантажений метод додавання для масивів чисел
    public static T[] Add<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Add(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод додавання для матриць
    public static T[,] Add<T>(T[,] a, T[,] b)
    {
        int rows = a.GetLength(0);
        int columns = a.GetLength(1);

        if (rows != b.GetLength(0) || columns != b.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        T[,] result = new T[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Add(a[i, j], b[i, j]);
            }
        }
        return result;
    }

    // Перевантажений метод віднімання для чисел
    public static T Subtract<T>(T a, T b)
    {
        dynamic dynamicA = a;
        dynamic dynamicB = b;
        return dynamicA - dynamicB;
    }

    // Перевантажений метод віднімання для масивів чисел
    public static T[] Subtract<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Subtract(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод віднімання для матриць
    public static T[,] Subtract<T>(T[,] a, T[,] b)
    {
        int rows = a.GetLength(0);
        int columns = a.GetLength(1);

        if (rows != b.GetLength(0) || columns != b.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        T[,] result = new T[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Subtract(a[i, j], b[i, j]);
            }
        }
        return result;
    }

    // Перевантажений метод множення для чисел
    public static T Multiply<T>(T a, T b)
    {
        dynamic dynamicA = a;
        dynamic dynamicB = b;
        return dynamicA * dynamicB;
    }

    // Перевантажений метод множення для масивів чисел
    public static T[] Multiply<T>(T[] a, T[] b)
    {
        if (a.Length != b.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        T[] result = new T[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Multiply(a[i], b[i]);
        }
        return result;
    }

    // Перевантажений метод множення для матриць
    public static T[,] Multiply<T>(T[,] a, T[,] b)
    {
        int rowsA = a.GetLength(0);
        int columnsA = a.GetLength(1);
        int rowsB = b.GetLength(0);
        int columnsB = b.GetLength(1);

        if (columnsA != rowsB)
        {
            throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
        }

        T[,] result = new T[rowsA, columnsB];
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                result[i, j] = default(T);
                for (int k = 0; k < columnsA; k++)
                {
                    result[i, j] = Add(result[i, j], Multiply(a[i, k], b[k, j]));
                }
            }
        }
        return result;
    }
}