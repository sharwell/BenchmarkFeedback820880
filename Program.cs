using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace benchmark
{
    public class Program
    {
        static double Add1(double a, double b) => a + b;

        static double Add2(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            new BenchmarkSwitcher(typeof(Program).Assembly).Run(args);
        }

        [Benchmark(OperationsPerInvoke = 1_000_000)]
        public double ExpressionBodied()
        {
            double result = 0;
            for (int i = 0; i < 1_000_000; i++)
            {
                result += Add1(1.3, 2.4);
            }

            return result;
        }

        [Benchmark(OperationsPerInvoke = 1_000_000)]
        public double BlockBodied()
        {
            double result = 0;
            for (int i = 0; i < 1_000_000; i++)
            {
                result += Add2(1.3, 2.4);
            }

            return result;
        }
    }
}
