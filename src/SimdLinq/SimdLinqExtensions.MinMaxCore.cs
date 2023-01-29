using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace SimdLinq;

public static partial class SimdLinqExtensions
{
    static T MinCore<T>(ReadOnlySpan<T> source)
        where T : struct, INumber<T>
    {
        if (source.IsEmpty) ThrowNoElements();

        if (!Vector128.IsHardwareAccelerated || source.Length < Vector128<T>.Count)
        {
            // Not SIMD supported or small source.
            var min = source[0];
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i] < min)
                {
                    min = source[i];
                }
            }
            return min;
        }
        else if (!Vector256.IsHardwareAccelerated || source.Length < Vector256<T>.Count)
        {
            // Only 128bit SIMD supported or small source.
            ref var current = ref MemoryMarshal.GetReference(source);
            ref var to = ref Unsafe.Add(ref current, source.Length - Vector128<T>.Count);

            var vectorMin = Vector128.LoadUnsafe(ref current);
            current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorMin = Vector128.Min(vectorMin, Vector128.LoadUnsafe(ref current));
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            vectorMin = Vector128.Min(vectorMin, Vector128.LoadUnsafe(ref to));

            var min = vectorMin[0];
            for (int i = 1; i < Vector128<T>.Count; i++)
            {
                if (vectorMin[i] < min)
                {
                    min = vectorMin[i];
                }
            }
            return min;
        }
        else
        {
            // 256bit SIMD supported
            ref var current = ref MemoryMarshal.GetReference(source);
            ref var to = ref Unsafe.Add(ref current, source.Length - Vector256<T>.Count);

            var vectorMin = Vector256.LoadUnsafe(ref current);
            current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorMin = Vector256.Min(vectorMin, Vector256.LoadUnsafe(ref current));
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            vectorMin = Vector256.Min(vectorMin, Vector256.LoadUnsafe(ref to));

            var min = vectorMin[0];
            for (int i = 1; i < Vector256<T>.Count; i++)
            {
                if (vectorMin[i] < min)
                {
                    min = vectorMin[i];
                }
            }
            return min;
        }
    }

    static T MaxCore<T>(ReadOnlySpan<T> source)
        where T : struct, INumber<T>
    {
        if (source.IsEmpty) ThrowNoElements();

        if (!Vector128.IsHardwareAccelerated || source.Length < Vector128<T>.Count)
        {
            // Not SIMD supported or small source.
            var max = source[0];
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i] > max)
                {
                    max = source[i];
                }
            }
            return max;
        }
        else if (!Vector256.IsHardwareAccelerated || source.Length < Vector256<T>.Count)
        {
            // Only 128bit SIMD supported or small source.
            ref var current = ref MemoryMarshal.GetReference(source);
            ref var to = ref Unsafe.Add(ref current, source.Length - Vector128<T>.Count);

            var vectorMax = Vector128.LoadUnsafe(ref current);
            current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorMax = Vector128.Max(vectorMax, Vector128.LoadUnsafe(ref current));
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            vectorMax = Vector128.Max(vectorMax, Vector128.LoadUnsafe(ref to));

            var max = vectorMax[0];
            for (int i = 1; i < Vector128<T>.Count; i++)
            {
                if (vectorMax[i] > max)
                {
                    max = vectorMax[i];
                }
            }
            return max;
        }
        else
        {
            // 256bit SIMD supported
            ref var current = ref MemoryMarshal.GetReference(source);
            ref var to = ref Unsafe.Add(ref current, source.Length - Vector256<T>.Count);

            var vectorMax = Vector256.LoadUnsafe(ref current);
            current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorMax = Vector256.Max(vectorMax, Vector256.LoadUnsafe(ref current));
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            vectorMax = Vector256.Max(vectorMax, Vector256.LoadUnsafe(ref to));

            var max = vectorMax[0];
            for (int i = 1; i < Vector256<T>.Count; i++)
            {
                if (vectorMax[i] > max)
                {
                    max = vectorMax[i];
                }
            }
            return max;
        }
    }

    static (T Min, T Max) MinMaxCore<T>(ReadOnlySpan<T> source)
        where T : struct, INumber<T>
    {
        if (source.IsEmpty) ThrowNoElements();

        if (!Vector128.IsHardwareAccelerated || source.Length < Vector128<T>.Count)
        {
            // Not SIMD supported or small source.
            var min = source[0];
            var max = min;
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i] < min)
                {
                    min = source[i];
                }
                if (source[i] > max)
                {
                    max = source[i];
                }
            }
            return (min, max);
        }
        else if (!Vector256.IsHardwareAccelerated || source.Length < Vector256<T>.Count)
        {
            // Only 128bit SIMD supported or small source.
            ref var current = ref MemoryMarshal.GetReference(source);
            ref var to = ref Unsafe.Add(ref current, source.Length - Vector128<T>.Count);

            var vectorMin = Vector128.LoadUnsafe(ref current);
            var vectorMax = vectorMin;
            current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorMin = Vector128.Min(vectorMin, Vector128.LoadUnsafe(ref current));
                vectorMax = Vector128.Max(vectorMax, Vector128.LoadUnsafe(ref current));
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            vectorMin = Vector128.Min(vectorMin, Vector128.LoadUnsafe(ref to));
            vectorMax = Vector128.Max(vectorMax, Vector128.LoadUnsafe(ref to));

            var min = vectorMin[0];
            var max = vectorMax[0];
            for (int i = 1; i < Vector128<T>.Count; i++)
            {
                if (vectorMin[i] < min)
                {
                    min = vectorMin[i];
                }
                if (vectorMax[i] > max)
                {
                    max = vectorMax[i];
                }
            }
            return (min, max);
        }
        else
        {
            // 256bit SIMD supported
            ref var current = ref MemoryMarshal.GetReference(source);
            ref var to = ref Unsafe.Add(ref current, source.Length - Vector256<T>.Count);

            var vectorMin = Vector256.LoadUnsafe(ref current);
            var vectorMax = vectorMin;
            current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            while (Unsafe.IsAddressLessThan(ref current, ref to))
            {
                vectorMin = Vector256.Min(vectorMin, Vector256.LoadUnsafe(ref current));
                vectorMax = Vector256.Max(vectorMax, Vector256.LoadUnsafe(ref current));
                current = ref Unsafe.Add(ref current, Vector256<T>.Count);
            }
            vectorMin = Vector256.Min(vectorMin, Vector256.LoadUnsafe(ref to));
            vectorMax = Vector256.Max(vectorMax, Vector256.LoadUnsafe(ref to));

            var min = vectorMin[0];
            var max = vectorMax[0];
            for (int i = 1; i < Vector256<T>.Count; i++)
            {
                if (vectorMin[i] < min)
                {
                    min = vectorMin[i];
                }
                if (vectorMax[i] > max)
                {
                    max = vectorMax[i];
                }
            }
            return (min, max);
        }
    }

    [DoesNotReturn]
    static void ThrowNoElements()
    {
        throw new Exception(); // TODO: throw no elements...
    }
}
