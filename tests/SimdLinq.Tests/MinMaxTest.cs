using System;
using System.Linq;

namespace SimdLinq.Tests;

public class MinMaxTest
{
    [Fact]
    public void MinHandlesNull()
    {
        // Arrange
        int[]? arr = null;

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr!.Min());
    }

    [Fact]
    public void MinHandlesEmpty()
    {
        // Arrange
        var arr = Array.Empty<int>();

        // Act Assert
        Assert.ThrowsAny<InvalidOperationException>(() => arr!.Min());
    }

    [Fact]
    public void Min()
    {
        MinTest(r => r.Next(), SimdLinqExtensions.Min);
        MinTest(r => r.NextInt64(), SimdLinqExtensions.Min);
        MinTest(r => r.NextSingle(), SimdLinqExtensions.Min);
        MinTest(r => r.NextDouble(), SimdLinqExtensions.Min);

        static void MinTest<T>(Func<Random, T> rng, Func<T[], T> simdMin)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd = simdMin(source);
                var reference = System.Linq.Enumerable.Min(source);
                simd.Should().Be(reference);
            }
        }
    }

    [Fact]
    public void MaxHandlesNull()
    {
        // Arrange
        int[]? arr = null;

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr!.Max());
    }

    [Fact]
    public void MaxHandlesEmpty()
    {
        // Arrange
        var arr = Array.Empty<int>();

        // Act Assert
        Assert.ThrowsAny<InvalidOperationException>(() => arr!.Max());
    }

    [Fact]
    public void Max()
    {
        MaxTest(r => r.Next(), SimdLinqExtensions.Max);
        MaxTest(r => r.NextInt64(), SimdLinqExtensions.Max);
        MaxTest(r => r.NextSingle(), SimdLinqExtensions.Max);
        MaxTest(r => r.NextDouble(), SimdLinqExtensions.Max);

        static void MaxTest<T>(Func<Random, T> rng, Func<T[], T> simdMax)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd = simdMax(source);
                var reference = System.Linq.Enumerable.Max(source);
                simd.Should().Be(reference);
            }
        }
    }

    [Fact]
    public void MinMaxHandlesNull()
    {
        // Arrange
        int[]? arr = null;

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr!.MinMax());
    }

    [Fact]
    public void MinMaxHandlesEmpty()
    {
        // Arrange
        var arr = Array.Empty<int>();

        // Act Assert
        Assert.ThrowsAny<InvalidOperationException>(() => arr!.MinMax());
    }

    [Fact]
    public void MinMax()
    {
        MinMaxTest(r => r.Next(), SimdLinqExtensions.MinMax);
        MinMaxTest(r => r.NextInt64(), SimdLinqExtensions.MinMax);
        MinMaxTest(r => r.NextSingle(), SimdLinqExtensions.MinMax);
        MinMaxTest(r => r.NextDouble(), SimdLinqExtensions.MinMax);

        static void MinMaxTest<T>(Func<Random, T> rng, Func<T[], (T, T)> simdMinMax)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd = simdMinMax(source);
                var refMin = System.Linq.Enumerable.Min(source);
                var refMax = System.Linq.Enumerable.Max(source);
                simd.Should().Be((refMin, refMax)!);
            }
        }
    }
}
