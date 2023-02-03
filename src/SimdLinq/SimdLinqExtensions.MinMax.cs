namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (byte Min, byte Max) MinMax(this byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<byte>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (byte Min, byte Max) MinMax(this List<byte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (byte Min, byte Max) MinMax(this Memory<byte> source)
    {
        return MinMaxCore((ReadOnlySpan<byte>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (byte Min, byte Max) MinMax(this ReadOnlyMemory<byte> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (byte Min, byte Max) MinMax(this Span<byte> source)
    {
        return MinMaxCore((ReadOnlySpan<byte>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (byte Min, byte Max) MinMax(this ReadOnlySpan<byte> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (sbyte Min, sbyte Max) MinMax(this sbyte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<sbyte>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (sbyte Min, sbyte Max) MinMax(this List<sbyte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (sbyte Min, sbyte Max) MinMax(this Memory<sbyte> source)
    {
        return MinMaxCore((ReadOnlySpan<sbyte>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (sbyte Min, sbyte Max) MinMax(this ReadOnlyMemory<sbyte> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (sbyte Min, sbyte Max) MinMax(this Span<sbyte> source)
    {
        return MinMaxCore((ReadOnlySpan<sbyte>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (sbyte Min, sbyte Max) MinMax(this ReadOnlySpan<sbyte> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (short Min, short Max) MinMax(this short[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<short>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (short Min, short Max) MinMax(this List<short> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (short Min, short Max) MinMax(this Memory<short> source)
    {
        return MinMaxCore((ReadOnlySpan<short>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (short Min, short Max) MinMax(this ReadOnlyMemory<short> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (short Min, short Max) MinMax(this Span<short> source)
    {
        return MinMaxCore((ReadOnlySpan<short>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (short Min, short Max) MinMax(this ReadOnlySpan<short> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ushort Min, ushort Max) MinMax(this ushort[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<ushort>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ushort Min, ushort Max) MinMax(this List<ushort> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ushort Min, ushort Max) MinMax(this Memory<ushort> source)
    {
        return MinMaxCore((ReadOnlySpan<ushort>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ushort Min, ushort Max) MinMax(this ReadOnlyMemory<ushort> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ushort Min, ushort Max) MinMax(this Span<ushort> source)
    {
        return MinMaxCore((ReadOnlySpan<ushort>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ushort Min, ushort Max) MinMax(this ReadOnlySpan<ushort> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (int Min, int Max) MinMax(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (int Min, int Max) MinMax(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (int Min, int Max) MinMax(this Memory<int> source)
    {
        return MinMaxCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (int Min, int Max) MinMax(this ReadOnlyMemory<int> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (int Min, int Max) MinMax(this Span<int> source)
    {
        return MinMaxCore((ReadOnlySpan<int>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (int Min, int Max) MinMax(this ReadOnlySpan<int> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (uint Min, uint Max) MinMax(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (uint Min, uint Max) MinMax(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (uint Min, uint Max) MinMax(this Memory<uint> source)
    {
        return MinMaxCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (uint Min, uint Max) MinMax(this ReadOnlyMemory<uint> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (uint Min, uint Max) MinMax(this Span<uint> source)
    {
        return MinMaxCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (uint Min, uint Max) MinMax(this ReadOnlySpan<uint> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (long Min, long Max) MinMax(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (long Min, long Max) MinMax(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (long Min, long Max) MinMax(this Memory<long> source)
    {
        return MinMaxCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (long Min, long Max) MinMax(this ReadOnlyMemory<long> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (long Min, long Max) MinMax(this Span<long> source)
    {
        return MinMaxCore((ReadOnlySpan<long>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (long Min, long Max) MinMax(this ReadOnlySpan<long> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ulong Min, ulong Max) MinMax(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ulong Min, ulong Max) MinMax(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ulong Min, ulong Max) MinMax(this Memory<ulong> source)
    {
        return MinMaxCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ulong Min, ulong Max) MinMax(this ReadOnlyMemory<ulong> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ulong Min, ulong Max) MinMax(this Span<ulong> source)
    {
        return MinMaxCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (ulong Min, ulong Max) MinMax(this ReadOnlySpan<ulong> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (float Min, float Max) MinMax(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (float Min, float Max) MinMax(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (float Min, float Max) MinMax(this Memory<float> source)
    {
        return MinMaxCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (float Min, float Max) MinMax(this ReadOnlyMemory<float> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (float Min, float Max) MinMax(this Span<float> source)
    {
        return MinMaxCore((ReadOnlySpan<float>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (float Min, float Max) MinMax(this ReadOnlySpan<float> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (double Min, double Max) MinMax(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (double Min, double Max) MinMax(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (double Min, double Max) MinMax(this Memory<double> source)
    {
        return MinMaxCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (double Min, double Max) MinMax(this ReadOnlyMemory<double> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (double Min, double Max) MinMax(this Span<double> source)
    {
        return MinMaxCore((ReadOnlySpan<double>)source);
    }

    /// <summary>
    /// Returns the minimum and maximum values in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum and maximum value of.</param>
    /// <returns>A tuple of the minimum and maximum values in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static (double Min, double Max) MinMax(this ReadOnlySpan<double> source)
    {
        return MinMaxCore(source);
    }

}

