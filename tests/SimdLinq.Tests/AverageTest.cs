using System;
using System.Linq;

namespace SimdLinq.Tests;

public class AverageTest
{
    [Fact]
    public void AverageHandlesNull()
    {
        // Arrange
        int[] arr = null;
        //arr.Sum()

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr.Average());
    }

    [Fact]
    public void MinHandlesNull()
    {
        // Arrange
        int[] arr = null;

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr.Min());
        Assert.Throws<ArgumentNullException>(() => arr.AsSpan().Min());
    }


    [Fact]
    public void Average()
    {
        AverageTest(x => x.Next(-100000, 100000), Enumerable.Average, SimdLinqExtensions.Average);
        AverageTest(x => x.NextInt64(-100000000, 10000000), Enumerable.Average, SimdLinqExtensions.Average);
        AverageTestSingle(x => x.NextSingle(), Enumerable.Average, SimdLinqExtensions.Average);
        AverageTestDouble(x => x.NextDouble(), Enumerable.Average, SimdLinqExtensions.Average);

        static void AverageTest<T>(Func<Random, T> rng, Func<T[], double> referenceFunc, Func<T[], double> simdFunc)
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

        static void AverageTestSingle(Func<Random, float> rng, Func<float[], float> referenceFunc, Func<float[], float> simdFunc)
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

        static void AverageTestDouble(Func<Random, double> rng, Func<double[], double> referenceFunc, Func<double[], double> simdFunc)
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
