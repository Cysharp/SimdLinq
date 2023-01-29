using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace SimdLinq;

public static partial class SimdLinqExtensions
{
    static bool ContainsCore<T>(ReadOnlySpan<T> source, T value)
        where T : struct, INumber<T>
    {
        T sum = T.Zero;

        if (!Vector128.IsHardwareAccelerated || source.Length < Vector128<T>.Count)
        {
            // Not SIMD supported or small source.
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == value)
                {
                    return true;
                }
            }
        }
        else if (!Vector256.IsHardwareAccelerated || source.Length < Vector256<T>.Count)
        {
            // Only 128bit SIMD supported or small source.
            ref var begin = ref MemoryMarshal.GetReference(source);
            ref var last = ref Unsafe.Add(ref begin, source.Length);
            ref var current = ref begin;

            var vectorValue = Vector128.Create(value);
            ref var to = ref Unsafe.Add(ref begin, source.Length - Vector128<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                if (Vector128.EqualsAny(Vector128.LoadUnsafe(ref current), vectorValue))
                {
                    return true;
                }
                current = ref Unsafe.Add(ref current, Vector128<T>.Count);
            }
            while (Unsafe.IsAddressLessThan(ref current, ref last))
            {
                if (current == value)
                {
                    return true;
                }
                current = ref Unsafe.Add(ref current, 1);
            }
        }
        else
        {
            // 256bit SIMD supported
            ref var begin = ref MemoryMarshal.GetReference(source);
            ref var last = ref Unsafe.Add(ref begin, source.Length);
            ref var current = ref begin;

            var vectorValue = Vector256.Create(value);
            ref var to = ref Unsafe.Add(ref begin, source.Length - Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                if (Vector256.EqualsAny(Vector256.LoadUnsafe(ref current), vectorValue))
                {
                    return true;
                }
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            while (Unsafe.IsAddressLessThan(ref current, ref last))
            {
                if (current == value)
                {
                    return true;
                }
                current = ref Unsafe.Add(ref current, 1);
            }
        }

        return false;
    }
}
