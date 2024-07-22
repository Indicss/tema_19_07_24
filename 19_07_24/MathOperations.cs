using System;

namespace GenericMathOperations
{
    public interface IOperations<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }

    public class IntOperations : IOperations<int>
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (b == 0) throw new ArgumentException("Divisor cannot be zero.");
            return a / b;
        }
    }

    public class FloatOperations : IOperations<float>
    {
        public float Add(float a, float b) => a + b;
        public float Subtract(float a, float b) => a - b;
        public float Multiply(float a, float b) => a * b;
        public float Divide(float a, float b)
        {
            if (b == 0) throw new ArgumentException("Divisor cannot be zero.");
            return a / b;
        }
    }

    public class DoubleOperations : IOperations<double>
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException("Divisor cannot be zero.");
            return a / b;
        }
    }

    public class MathOperations<T>
    {
        private readonly IOperations<T> _operations;

        public MathOperations(IOperations<T> operations)
        {
            _operations = operations;
        }

        public T Add(T a, T b) => _operations.Add(a, b);
        public T Subtract(T a, T b) => _operations.Subtract(a, b);
        public T Multiply(T a, T b) => _operations.Multiply(a, b);
        public T Divide(T a, T b) => _operations.Divide(a, b);
    }
}
