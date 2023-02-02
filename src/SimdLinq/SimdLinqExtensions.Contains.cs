namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Determines whether a sequence of <see cref="byte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this byte[] source, byte value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<byte>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="byte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<byte> source, byte value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="byte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<byte> source, byte value)
    {
        return ContainsCore((ReadOnlySpan<byte>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="byte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<byte> source, byte value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="byte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<byte> source, byte value)
    {
        return ContainsCore((ReadOnlySpan<byte>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="byte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="byte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<byte> source, byte value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="sbyte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this sbyte[] source, sbyte value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<sbyte>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="sbyte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<sbyte> source, sbyte value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="sbyte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<sbyte> source, sbyte value)
    {
        return ContainsCore((ReadOnlySpan<sbyte>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="sbyte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<sbyte> source, sbyte value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="sbyte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<sbyte> source, sbyte value)
    {
        return ContainsCore((ReadOnlySpan<sbyte>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="sbyte"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="sbyte"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<sbyte> source, sbyte value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="short"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this short[] source, short value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<short>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="short"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<short> source, short value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="short"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<short> source, short value)
    {
        return ContainsCore((ReadOnlySpan<short>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="short"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<short> source, short value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="short"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<short> source, short value)
    {
        return ContainsCore((ReadOnlySpan<short>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="short"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="short"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<short> source, short value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="ushort"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ushort[] source, ushort value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<ushort>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ushort"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<ushort> source, ushort value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ushort"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<ushort> source, ushort value)
    {
        return ContainsCore((ReadOnlySpan<ushort>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ushort"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<ushort> source, ushort value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ushort"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<ushort> source, ushort value)
    {
        return ContainsCore((ReadOnlySpan<ushort>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ushort"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ushort"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<ushort> source, ushort value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="int"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this int[] source, int value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<int>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="int"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<int> source, int value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="int"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<int> source, int value)
    {
        return ContainsCore((ReadOnlySpan<int>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="int"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<int> source, int value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="int"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<int> source, int value)
    {
        return ContainsCore((ReadOnlySpan<int>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="int"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="int"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<int> source, int value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="uint"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this uint[] source, uint value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<uint>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="uint"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<uint> source, uint value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="uint"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<uint> source, uint value)
    {
        return ContainsCore((ReadOnlySpan<uint>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="uint"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<uint> source, uint value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="uint"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<uint> source, uint value)
    {
        return ContainsCore((ReadOnlySpan<uint>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="uint"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="uint"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<uint> source, uint value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="long"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this long[] source, long value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<long>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="long"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<long> source, long value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="long"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<long> source, long value)
    {
        return ContainsCore((ReadOnlySpan<long>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="long"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<long> source, long value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="long"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<long> source, long value)
    {
        return ContainsCore((ReadOnlySpan<long>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="long"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="long"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<long> source, long value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="ulong"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ulong[] source, ulong value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<ulong>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ulong"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<ulong> source, ulong value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ulong"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<ulong> source, ulong value)
    {
        return ContainsCore((ReadOnlySpan<ulong>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ulong"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<ulong> source, ulong value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ulong"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<ulong> source, ulong value)
    {
        return ContainsCore((ReadOnlySpan<ulong>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="ulong"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <param name="source">A sequence of <see cref="ulong"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<ulong> source, ulong value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="float"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this float[] source, float value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<float>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="float"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<float> source, float value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="float"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<float> source, float value)
    {
        return ContainsCore((ReadOnlySpan<float>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="float"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<float> source, float value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="float"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<float> source, float value)
    {
        return ContainsCore((ReadOnlySpan<float>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="float"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="float"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<float> source, float value)
    {
        return ContainsCore(source, value);
    }
    /// <summary>
    /// Determines whether a sequence of <see cref="double"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this double[] source, double value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore(new ReadOnlySpan<double>(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="double"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this List<double> source, double value)
    {
        ArgumentNullException.ThrowIfNull(source);
        return ContainsCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source), value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="double"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Memory<double> source, double value)
    {
        return ContainsCore((ReadOnlySpan<double>)source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="double"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlyMemory<double> source, double value)
    {
        return ContainsCore(source.Span, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="double"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this Span<double> source, double value)
    {
        return ContainsCore((ReadOnlySpan<double>)source, value);
    }

    /// <summary>
    /// Determines whether a sequence of <see cref="double"/> contains a specified element using SIMD acceleration.
    /// </summary>
    /// <remarks>This method does not check for <see cref="float.NaN"/> <see cref="float"/>/<see cref="double"/> values and should not be used when <paramref name="source"/> may contain one.</remarks>
    /// <param name="source">A sequence of <see cref="double"/> values in which to locate a value.</param>
    /// <param name="value">The value to locate in the sequence.</param>
    /// <returns><see langword="true"/> if the source sequence contains an element that has the specified value; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static bool Contains(this ReadOnlySpan<double> source, double value)
    {
        return ContainsCore(source, value);
    }
}
