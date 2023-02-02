using System;
using System.Linq;

namespace SimdLinq.Tests;

public class ContainsTest
{
    [Fact]
    public void ContainsHandlesNull()
    {
        // Arrange
        int[]? arr = null;

        // Act Assert
        Assert.Throws<ArgumentNullException>(() => arr!.Contains(0));
    }

    [Fact]
    public void Contains()
    {
        ContainsTest(x => x.Next(-100000, 100000), Enumerable.Contains, SimdLinqExtensions.Contains);
        ContainsTest(x => x.NextInt64(-1000000, 100000), Enumerable.Contains, SimdLinqExtensions.Contains);
        ContainsTest(x => x.NextSingle(), Enumerable.Contains, SimdLinqExtensions.Contains);
        ContainsTest(x => x.NextDouble(), Enumerable.Contains, SimdLinqExtensions.Contains);

        static void ContainsTest<T>(Func<Random, T> rng, Func<T[], T, bool> referenceFunc, Func<T[], T, bool> simdFunc)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();
                var v = source[rand.Next(0, i)];

                var simd1 = simdFunc(source, v);
                var ref1 = referenceFunc(source, v);
                simd1.Should().Be(ref1);
                simd1.Should().BeTrue();

                var v2 = rng(rand);
                var simd2 = simdFunc(source, v);
                var ref2 = referenceFunc(source, v);
                simd2.Should().Be(ref2);
            }
        }
    }
}
