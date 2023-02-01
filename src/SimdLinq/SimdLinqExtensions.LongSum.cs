namespace SimdLinq;

using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Computes the long sum of a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    public static long LongSum(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    public static long LongSum(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static long LongSum(this Memory<int> source)
    {
        return LongSumCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static long LongSum(this ReadOnlyMemory<int> source)
    {
        return LongSumCore(source.Span);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static long LongSum(this Span<int> source)
    {
        return LongSumCore((ReadOnlySpan<int>)source);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static long LongSum(this ReadOnlySpan<int> source)
    {
        return LongSumCore(source);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    public static ulong LongSum(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    public static ulong LongSum(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static ulong LongSum(this Memory<uint> source)
    {
        return LongSumCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static ulong LongSum(this ReadOnlyMemory<uint> source)
    {
        return LongSumCore(source.Span);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static ulong LongSum(this Span<uint> source)
    {
        return LongSumCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>
    /// Computes the long sum of a collection of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike Linq.Sum this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the long sum of.</param>
    /// <returns>The sum of the values in the collection.</returns>
    public static ulong LongSum(this ReadOnlySpan<uint> source)
    {
        return LongSumCore(source);
    }

}

