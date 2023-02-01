namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Computes the average of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Memory<int> source)
    {
        return AverageCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlyMemory<int> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Span<int> source)
    {
        return AverageCore((ReadOnlySpan<int>)source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="int"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlySpan<int> source)
    {
        return AverageCore(source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Memory<long> source)
    {
        return AverageCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlyMemory<long> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Span<long> source)
    {
        return AverageCore((ReadOnlySpan<long>)source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="long"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlySpan<long> source)
    {
        return AverageCore(source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="double"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="double"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="double"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Memory<double> source)
    {
        return AverageCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="double"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlyMemory<double> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="double"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Span<double> source)
    {
        return AverageCore((ReadOnlySpan<double>)source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="double"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlySpan<double> source)
    {
        return AverageCore(source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="float"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Average(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="float"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Average(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="float"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Average(this Memory<float> source)
    {
        return AverageCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="float"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Average(this ReadOnlyMemory<float> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="float"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Average(this Span<float> source)
    {
        return AverageCore((ReadOnlySpan<float>)source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Average.</para>
    /// <param name="source">A collection of <see cref="float"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static float Average(this ReadOnlySpan<float> source)
    {
        return AverageCore(source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Memory<uint> source)
    {
        return AverageCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlyMemory<uint> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Span<uint> source)
    {
        return AverageCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="uint"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlySpan<uint> source)
    {
        return AverageCore(source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Memory<ulong> source)
    {
        return AverageCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlyMemory<ulong> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this Span<ulong> source)
    {
        return AverageCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>
    /// Computes the average of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <param name="source">A collection of <see cref="ulong"/> values to calculate the average of.</param>
    /// <returns>The average of the collection of values.</returns>
    /// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
    public static double Average(this ReadOnlySpan<ulong> source)
    {
        return AverageCore(source);
    }

}

