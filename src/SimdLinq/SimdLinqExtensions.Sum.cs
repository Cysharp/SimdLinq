namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>
    /// Computes the sum of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="int"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static int Sum(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="int"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static int Sum(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="int"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static int Sum(this Memory<int> source)
    {
        return SumCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="int"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static int Sum(this ReadOnlyMemory<int> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="int"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static int Sum(this Span<int> source)
    {
        return SumCore((ReadOnlySpan<int>)source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="int"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="int"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static int Sum(this ReadOnlySpan<int> source)
    {
        return SumCore(source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="uint"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static uint Sum(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="uint"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static uint Sum(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="uint"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static uint Sum(this Memory<uint> source)
    {
        return SumCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="uint"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static uint Sum(this ReadOnlyMemory<uint> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="uint"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static uint Sum(this Span<uint> source)
    {
        return SumCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="uint"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{int})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="uint"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static uint Sum(this ReadOnlySpan<uint> source)
    {
        return SumCore(source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="long"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static long Sum(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="long"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static long Sum(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="long"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static long Sum(this Memory<long> source)
    {
        return SumCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="long"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static long Sum(this ReadOnlyMemory<long> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="long"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static long Sum(this Span<long> source)
    {
        return SumCore((ReadOnlySpan<long>)source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="long"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="long"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static long Sum(this ReadOnlySpan<long> source)
    {
        return SumCore(source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="ulong"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static ulong Sum(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="ulong"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static ulong Sum(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="ulong"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static ulong Sum(this Memory<ulong> source)
    {
        return SumCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="ulong"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static ulong Sum(this ReadOnlyMemory<ulong> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="ulong"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static ulong Sum(this Span<ulong> source)
    {
        return SumCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="ulong"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{long})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="ulong"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static ulong Sum(this ReadOnlySpan<ulong> source)
    {
        return SumCore(source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{float})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static float Sum(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{float})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static float Sum(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{float})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static float Sum(this Memory<float> source)
    {
        return SumCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{float})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static float Sum(this ReadOnlyMemory<float> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{float})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static float Sum(this Span<float> source)
    {
        return SumCore((ReadOnlySpan<float>)source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="float"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{float})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="float"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static float Sum(this ReadOnlySpan<float> source)
    {
        return SumCore(source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{double})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static double Sum(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{double})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is <see langword="null"/>.</exception>
    public static double Sum(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{double})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static double Sum(this Memory<double> source)
    {
        return SumCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{double})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static double Sum(this ReadOnlyMemory<double> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{double})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static double Sum(this Span<double> source)
    {
        return SumCore((ReadOnlySpan<double>)source);
    }

    /// <summary>
    /// Computes the sum of a sequence of <see cref="double"/> values using SIMD acceleration.
    /// </summary>
    /// <remarks>
    /// <para>Note that unlike <see cref="Enumerable.Sum(IEnumerable{double})"/> this method is unchecked and will not throw an <see cref="OverflowException"/>.</para>
    /// <para>Unlike Linq, the order for the sum calculation is not sequential, leading to slight differences in floating-point operations and the resulting value. While this difference is minimal you should not use this method if you require the same result as Linq.Sum.</para>
    /// </remarks>
    /// <param name="source">A sequence of <see cref="double"/> values to calculate the sum of.</param>
    /// <returns>The sum of the values in the sequence.</returns>
    public static double Sum(this ReadOnlySpan<double> source)
    {
        return SumCore(source);
    }

}

