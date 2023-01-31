using System;
using System.Linq;

namespace SimdLinq.Tests;

public class SumTest
{
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

    [Fact]
    public void LongSum()
    {
        var rand = new Random();
        for (int i = 1; i < 1024; i++)
        {
            var source = Enumerable.Range(1, i).Select(x => rand.Next(-100000, 100000)).ToArray();

            var simd = SimdLinqExtensions.LongSum(source);
            var reference = Enumerable.Sum(source, x => (long)x);
            (simd).Should().Be(reference);
        }

        for (int i = 1; i < 1024; i++)
        {
            var source = Enumerable.Range(1, i).Select(x => (uint)rand.Next(0, 200000)).ToArray();

            var simd = SimdLinqExtensions.LongSum(source);
            var reference = (ulong)Enumerable.Sum(source, x => x);
            (simd).Should().Be(reference);
        }
    }
}
