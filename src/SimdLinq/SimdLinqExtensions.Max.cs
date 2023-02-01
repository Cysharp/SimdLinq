namespace SimdLinq;

using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Returns the maximum value in a collection of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="byte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Max(this byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<byte>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="byte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Max(this List<byte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="byte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Max(this Memory<byte> source)
    {
        return MaxCore((ReadOnlySpan<byte>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="byte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Max(this ReadOnlyMemory<byte> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="byte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Max(this Span<byte> source)
    {
        return MaxCore((ReadOnlySpan<byte>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="byte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Max(this ReadOnlySpan<byte> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="sbyte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Max(this sbyte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<sbyte>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="sbyte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Max(this List<sbyte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="sbyte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Max(this Memory<sbyte> source)
    {
        return MaxCore((ReadOnlySpan<sbyte>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="sbyte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Max(this ReadOnlyMemory<sbyte> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="sbyte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Max(this Span<sbyte> source)
    {
        return MaxCore((ReadOnlySpan<sbyte>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="sbyte"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Max(this ReadOnlySpan<sbyte> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="short"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Max(this short[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<short>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="short"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Max(this List<short> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="short"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Max(this Memory<short> source)
    {
        return MaxCore((ReadOnlySpan<short>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="short"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Max(this ReadOnlyMemory<short> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="short"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Max(this Span<short> source)
    {
        return MaxCore((ReadOnlySpan<short>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="short"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Max(this ReadOnlySpan<short> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ushort"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Max(this ushort[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<ushort>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ushort"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Max(this List<ushort> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ushort"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Max(this Memory<ushort> source)
    {
        return MaxCore((ReadOnlySpan<ushort>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ushort"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Max(this ReadOnlyMemory<ushort> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ushort"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Max(this Span<ushort> source)
    {
        return MaxCore((ReadOnlySpan<ushort>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ushort"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Max(this ReadOnlySpan<ushort> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Max(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Max(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Max(this Memory<int> source)
    {
        return MaxCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Max(this ReadOnlyMemory<int> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Max(this Span<int> source)
    {
        return MaxCore((ReadOnlySpan<int>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Max(this ReadOnlySpan<int> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Max(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Max(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Max(this Memory<uint> source)
    {
        return MaxCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Max(this ReadOnlyMemory<uint> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Max(this Span<uint> source)
    {
        return MaxCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Max(this ReadOnlySpan<uint> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Max(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Max(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Max(this Memory<long> source)
    {
        return MaxCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Max(this ReadOnlyMemory<long> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Max(this Span<long> source)
    {
        return MaxCore((ReadOnlySpan<long>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Max(this ReadOnlySpan<long> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Max(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Max(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Max(this Memory<ulong> source)
    {
        return MaxCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Max(this ReadOnlyMemory<ulong> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Max(this Span<ulong> source)
    {
        return MaxCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Max(this ReadOnlySpan<ulong> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="float"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Max(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="float"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Max(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="float"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Max(this Memory<float> source)
    {
        return MaxCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="float"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Max(this ReadOnlyMemory<float> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="float"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Max(this Span<float> source)
    {
        return MaxCore((ReadOnlySpan<float>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="float"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Max(this ReadOnlySpan<float> source)
    {
        return MaxCore(source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="double"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Max(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="double"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Max(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="double"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Max(this Memory<double> source)
    {
        return MaxCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="double"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Max(this ReadOnlyMemory<double> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="double"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Max(this Span<double> source)
    {
        return MaxCore((ReadOnlySpan<double>)source);
    }

    /// <summary>
    /// Returns the maximum value in a collection of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A collection of <see cref="double"/> values to determine the maximum value of.</param>
    /// <returns>The maximum value in the collection.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Max(this ReadOnlySpan<double> source)
    {
        return MaxCore(source);
    }

}

