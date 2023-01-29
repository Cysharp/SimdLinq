using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace SimdLinq.Tests;

public class SequenceEqualTest
{
    [Fact]
    public void SequenceEqual()
    {
        ContainsTest(x => x.Next(-100000, 100000), Enumerable.SequenceEqual, SimdLinqExtensions.SequenceEqual);

        static void ContainsTest<T>(Func<Random, T> rng, Func<T[], T[], bool> referenceFunc, Func<T[], T[], bool> simdFunc)
        {
            var rand = new Random();
            for (int i = 1; i < 1024; i++)
            {
                var source = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();
                var source2 = Enumerable.Range(1, i).Select(x => rng(rand)).ToArray();

                var simd1 = simdFunc(source, source);
                var ref1 = referenceFunc(source, source);
                simd1.Should().Be(ref1);

                var v2 = rng(rand);
                var simd2 = simdFunc(source, source2);
                var ref2 = referenceFunc(source, source2);
                simd2.Should().Be(ref2);
            }
        }
    }
}
