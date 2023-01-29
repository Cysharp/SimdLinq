using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace SimdLinq;

public static partial class SimdLinqExtensions
{
    // Enumerable Sum => int, long, double, float, decimal
    // Additional: uint, ulong
    // Drop: decimal

    static T SumCore<T>(ReadOnlySpan<T> source)
        where T : struct, INumber<T>
    {
        T sum = T.Zero;

        if (!Vector128.IsHardwareAccelerated || source.Length < Vector128<T>.Count)
        {
            // Not SIMD supported or small source.
            unchecked // SIMD operation is unchecked so keep same behaviour
            {
                for (int i = 0; i < source.Length; i++)
                {
                    sum += source[i];
                }
            }
        }
        else if (!Vector256.IsHardwareAccelerated || source.Length < Vector256<T>.Count)
        {
            // Only 128bit SIMD supported or small source.
            ref var begin = ref MemoryMarshal.GetReference(source);
            ref var last = ref Unsafe.Add(ref begin, source.Length);
            ref var current = ref begin;
            var vectorSum = Vector128<T>.Zero;
            
            ref var to = ref Unsafe.Add(ref begin, source.Length - Vector128<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorSum += Vector128.LoadUnsafe(ref current);
                current = ref Unsafe.Add(ref current, Vector128<T>.Count);
            }
            while (Unsafe.IsAddressLessThan(ref current, ref last))
            {
                unchecked // SIMD operation is unchecked so keep same behaviour
                {
                    sum += current;
                }
                current = ref Unsafe.Add(ref current, 1);
            }

            sum += Vector128.Sum(vectorSum);
        }
        else
        {
            // 256bit SIMD supported
            ref var begin = ref MemoryMarshal.GetReference(source);
            ref var last = ref Unsafe.Add(ref begin, source.Length);
            ref var current = ref begin;
            var vectorSum = Vector256<T>.Zero;

            ref var to = ref Unsafe.Add(ref begin, source.Length - Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorSum += Vector256.LoadUnsafe(ref current);
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            while (Unsafe.IsAddressLessThan(ref current, ref last))
            {
                unchecked // SIMD operation is unchecked so keep same behaviour
                {
                    sum += current;
                }
                current = ref Unsafe.Add(ref current, 1);
            }

            sum += Vector256.Sum(vectorSum);
        }

        return sum;
    }
}
