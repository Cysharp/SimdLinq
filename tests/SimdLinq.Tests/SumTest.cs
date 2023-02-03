using System;
using System.Linq;

namespace SimdLinq.Tests;

public class SumTest
{
    [Fact]
    public void SumHandlesNull()
    {
        // Arrange
        int[]? arr = null;

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr!.Sum());
    }

    [Fact]
    public void Sum()
    {
        SumTest(x => x.Next(-100000, 100000), Enumerable.Sum, SimdLinqExtensions.Sum);
        SumTest(x => (uint)x.Next(0, 100000), x => (uint)x.Sum(y => (int)y), SimdLinqExtensions.Sum);
        SumTest(x => x.NextInt64(-100000000, 10000000), Enumerable.Sum, SimdLinqExtensions.Sum);
        SumTest(x => (ulong)x.NextInt64(-0, 10000000), x => (ulong)x.Sum(y => (long)y), SimdLinqExtensions.Sum);
        SumTestSingle(x => x.NextSingle(), Enumerable.Sum, SimdLinqExtensions.Sum);
        SumTestDouble(x => x.NextDouble(), Enumerable.Sum, SimdLinqExtensions.Sum);

        static void SumTest<T>(Func<Random, T> rng, Func<T[], T> referenceFunc, Func<T[], T> simdFunc)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd = simdFunc(source);
                var reference = referenceFunc(source);
                simd.Should().Be(reference);
            }
        }

        static void SumTestSingle(Func<Random, float> rng, Func<float[], float> referenceFunc, Func<float[], float> simdFunc)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd = simdFunc(source);
                var reference = referenceFunc(source);

                Assert.Equal((double)simd, (double)reference, 1.0);
            }
        }

        static void SumTestDouble(Func<Random, double> rng, Func<double[], double> referenceFunc, Func<double[], double> simdFunc)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd = simdFunc(source);
                var reference = referenceFunc(source);

                Assert.Equal((double)simd, (double)reference, 1.0);
            }
        }
    }
}
