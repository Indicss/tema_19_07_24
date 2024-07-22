using System;
using GenericMathOperations;

namespace GenericMathOperationsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var intOps = new MathOperations<int>(new IntOperations());
            Console.WriteLine($"Add: {intOps.Add(3, 5)}");
            Console.WriteLine($"Subtract: {intOps.Subtract(10, 4)}");
            Console.WriteLine($"Multiply: {intOps.Multiply(2, 3)}");
            Console.WriteLine($"Divide: {intOps.Divide(8, 2)}");

            var floatOps = new MathOperations<float>(new FloatOperations());
            Console.WriteLine($"Add: {floatOps.Add(3.5f, 5.1f)}");
            Console.WriteLine($"Subtract: {floatOps.Subtract(10.0f, 4.2f)}");
            Console.WriteLine($"Multiply: {floatOps.Multiply(2.5f, 3.0f)}");
            Console.WriteLine($"Divide: {floatOps.Divide(8.4f, 2.1f)}");

            var doubleOps = new MathOperations<double>(new DoubleOperations());
            Console.WriteLine($"Add: {doubleOps.Add(3.5, 5.1)}");
            Console.WriteLine($"Subtract: {doubleOps.Subtract(10.0, 4.2)}");
            Console.WriteLine($"Multiply: {doubleOps.Multiply(2.5, 3.0)}");
            Console.WriteLine($"Divide: {doubleOps.Divide(8.4, 2.1)}");
        }
    }
}
