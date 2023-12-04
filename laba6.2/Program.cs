class Program
{
    static void Main()
    {
        // Приклад використання
        Quaternion q1 = new Quaternion(1, 2, 3, 4);
        Quaternion q2 = new Quaternion(5, 6, 7, 8);

        Quaternion sum = q1 + q2;
        Quaternion difference = q1 - q2;
        Quaternion product = q1 * q2;

        Console.WriteLine($"Sum: {sum.W}, {sum.X}, {sum.Y}, {sum.Z}");
        Console.WriteLine($"Difference: {difference.W}, {difference.X}, {difference.Y}, {difference.Z}");
        Console.WriteLine($"Product: {product.W}, {product.X}, {product.Y}, {product.Z}");

        Console.WriteLine($"Magnitude of q1: {q1.Magnitude()}");
        Console.WriteLine($"Conjugate of q1: {q1.Conjugate().W}, {q1.Conjugate().X}, {q1.Conjugate().Y}, {q1.Conjugate().Z}");
        Console.WriteLine($"Inverse of q1: {q1.Inverse().W}, {q1.Inverse().X}, {q1.Inverse().Y}, {q1.Inverse().Z}");

        Console.WriteLine($"Are q1 and q2 equal? {q1 == q2}");
        Console.WriteLine($"Are q1 and q2 not equal? {q1 != q2}");

        double[,] rotationMatrix = q1.ToRotationMatrix();
        Console.WriteLine("Rotation Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(rotationMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
