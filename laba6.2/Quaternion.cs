using System;

public class Quaternion
{
    public double W { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    // Операції додавання
    public static Quaternion operator +(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    // Операції віднімання
    public static Quaternion operator -(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    // Операція множення
    public static Quaternion operator *(Quaternion a, Quaternion b)
    {
        double w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;
        double x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
        double y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
        double z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;

        return new Quaternion(w, x, y, z);
    }

    // Обчислення норми
    public double Magnitude()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    // Обчислення спряженого кватерніона
    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    // Обчислення інверсного кватерніона
    public Quaternion Inverse()
    {
        double magnitudeSquared = W * W + X * X + Y * Y + Z * Z;

        if (magnitudeSquared > 0)
        {
            double invMagnitudeSquared = 1.0 / magnitudeSquared;
            return new Quaternion(W * invMagnitudeSquared, -X * invMagnitudeSquared, -Y * invMagnitudeSquared, -Z * invMagnitudeSquared);
        }

        throw new InvalidOperationException("Cannot calculate inverse for a quaternion with zero magnitude.");
    }

    // Перевантажені версії операцій порівняння
    public static bool operator ==(Quaternion a, Quaternion b)
    {
        return a.W == b.W && a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    public static bool operator !=(Quaternion a, Quaternion b)
    {
        return !(a == b);
    }

    // Конвертація кватерніона в матрицю обертання
    public double[,] ToRotationMatrix()
    {
        double[,] matrix = new double[3, 3];

        double xx = X * X;
        double xy = X * Y;
        double xz = X * Z;
        double xw = X * W;

        double yy = Y * Y;
        double yz = Y * Z;
        double yw = Y * W;

        double zz = Z * Z;
        double zw = Z * W;

        matrix[0, 0] = 1 - 2 * (yy + zz);
        matrix[0, 1] = 2 * (xy - zw);
        matrix[0, 2] = 2 * (xz + yw);

        matrix[1, 0] = 2 * (xy + zw);
        matrix[1, 1] = 1 - 2 * (xx + zz);
        matrix[1, 2] = 2 * (yz - xw);

        matrix[2, 0] = 2 * (xz - yw);
        matrix[2, 1] = 2 * (yz + xw);
        matrix[2, 2] = 1 - 2 * (xx + yy);

        return matrix;
    }
}