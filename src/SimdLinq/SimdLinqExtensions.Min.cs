namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Min(this byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<byte>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Min(this List<byte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Min(this Memory<byte> source)
    {
        return MinCore((ReadOnlySpan<byte>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Min(this ReadOnlyMemory<byte> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Min(this Span<byte> source)
    {
        return MinCore((ReadOnlySpan<byte>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="byte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static byte Min(this ReadOnlySpan<byte> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Min(this sbyte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<sbyte>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Min(this List<sbyte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Min(this Memory<sbyte> source)
    {
        return MinCore((ReadOnlySpan<sbyte>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Min(this ReadOnlyMemory<sbyte> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Min(this Span<sbyte> source)
    {
        return MinCore((ReadOnlySpan<sbyte>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="sbyte"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static sbyte Min(this ReadOnlySpan<sbyte> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Min(this short[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<short>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Min(this List<short> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Min(this Memory<short> source)
    {
        return MinCore((ReadOnlySpan<short>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Min(this ReadOnlyMemory<short> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Min(this Span<short> source)
    {
        return MinCore((ReadOnlySpan<short>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="short"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static short Min(this ReadOnlySpan<short> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Min(this ushort[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<ushort>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Min(this List<ushort> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Min(this Memory<ushort> source)
    {
        return MinCore((ReadOnlySpan<ushort>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Min(this ReadOnlyMemory<ushort> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Min(this Span<ushort> source)
    {
        return MinCore((ReadOnlySpan<ushort>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ushort"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ushort Min(this ReadOnlySpan<ushort> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Min(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Min(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Min(this Memory<int> source)
    {
        return MinCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Min(this ReadOnlyMemory<int> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Min(this Span<int> source)
    {
        return MinCore((ReadOnlySpan<int>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static int Min(this ReadOnlySpan<int> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Min(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Min(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Min(this Memory<uint> source)
    {
        return MinCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Min(this ReadOnlyMemory<uint> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Min(this Span<uint> source)
    {
        return MinCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static uint Min(this ReadOnlySpan<uint> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Min(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Min(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Min(this Memory<long> source)
    {
        return MinCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Min(this ReadOnlyMemory<long> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Min(this Span<long> source)
    {
        return MinCore((ReadOnlySpan<long>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static long Min(this ReadOnlySpan<long> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Min(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Min(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Min(this Memory<ulong> source)
    {
        return MinCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Min(this ReadOnlyMemory<ulong> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Min(this Span<ulong> source)
    {
        return MinCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static ulong Min(this ReadOnlySpan<ulong> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Min(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Min(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Min(this Memory<float> source)
    {
        return MinCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Min(this ReadOnlyMemory<float> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Min(this Span<float> source)
    {
        return MinCore((ReadOnlySpan<float>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Min(this ReadOnlySpan<float> source)
    {
        return MinCore(source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Min(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Min(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Min(this Memory<double> source)
    {
        return MinCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Min(this ReadOnlyMemory<double> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Min(this Span<double> source)
    {
        return MinCore((ReadOnlySpan<double>)source);
    }

    /// <summary>
    /// Returns the minimum value in a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to determine the minimum value of.</param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Min(this ReadOnlySpan<double> source)
    {
        return MinCore(source);
    }

}

