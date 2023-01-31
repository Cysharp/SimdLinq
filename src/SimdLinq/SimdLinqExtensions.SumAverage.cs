namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>Compute Sum in SIMD.</summary>
    public static int Sum(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static int Sum(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static int Sum(this Memory<int> source)
    {
        return SumCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static int Sum(this ReadOnlyMemory<int> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static int Sum(this Span<int> source)
    {
        return SumCore((ReadOnlySpan<int>)source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static int Sum(this ReadOnlySpan<int> source)
    {
        return SumCore(source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static long Sum(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static long Sum(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static long Sum(this Memory<long> source)
    {
        return SumCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static long Sum(this ReadOnlyMemory<long> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static long Sum(this Span<long> source)
    {
        return SumCore((ReadOnlySpan<long>)source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static long Sum(this ReadOnlySpan<long> source)
    {
        return SumCore(source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static double Sum(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static double Sum(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static double Sum(this Memory<double> source)
    {
        return SumCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static double Sum(this ReadOnlyMemory<double> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static double Sum(this Span<double> source)
    {
        return SumCore((ReadOnlySpan<double>)source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static double Sum(this ReadOnlySpan<double> source)
    {
        return SumCore(source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static float Sum(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static float Sum(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static float Sum(this Memory<float> source)
    {
        return SumCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static float Sum(this ReadOnlyMemory<float> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static float Sum(this Span<float> source)
    {
        return SumCore((ReadOnlySpan<float>)source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static float Sum(this ReadOnlySpan<float> source)
    {
        return SumCore(source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static uint Sum(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static uint Sum(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static uint Sum(this Memory<uint> source)
    {
        return SumCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static uint Sum(this ReadOnlyMemory<uint> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static uint Sum(this Span<uint> source)
    {
        return SumCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static uint Sum(this ReadOnlySpan<uint> source)
    {
        return SumCore(source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static ulong Sum(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static ulong Sum(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return SumCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static ulong Sum(this Memory<ulong> source)
    {
        return SumCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static ulong Sum(this ReadOnlyMemory<ulong> source)
    {
        return SumCore(source.Span);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static ulong Sum(this Span<ulong> source)
    {
        return SumCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>Compute Sum in SIMD.</summary>
    public static ulong Sum(this ReadOnlySpan<ulong> source)
    {
        return SumCore(source);
    }

}


public static partial class SimdLinqExtensions
{
    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Memory<int> source)
    {
        return AverageCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlyMemory<int> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Span<int> source)
    {
        return AverageCore((ReadOnlySpan<int>)source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlySpan<int> source)
    {
        return AverageCore(source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Memory<long> source)
    {
        return AverageCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlyMemory<long> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Span<long> source)
    {
        return AverageCore((ReadOnlySpan<long>)source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlySpan<long> source)
    {
        return AverageCore(source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Memory<double> source)
    {
        return AverageCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlyMemory<double> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Span<double> source)
    {
        return AverageCore((ReadOnlySpan<double>)source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlySpan<double> source)
    {
        return AverageCore(source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static float Average(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static float Average(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static float Average(this Memory<float> source)
    {
        return AverageCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static float Average(this ReadOnlyMemory<float> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static float Average(this Span<float> source)
    {
        return AverageCore((ReadOnlySpan<float>)source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static float Average(this ReadOnlySpan<float> source)
    {
        return AverageCore(source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Memory<uint> source)
    {
        return AverageCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlyMemory<uint> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Span<uint> source)
    {
        return AverageCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlySpan<uint> source)
    {
        return AverageCore(source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return AverageCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Memory<ulong> source)
    {
        return AverageCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlyMemory<ulong> source)
    {
        return AverageCore(source.Span);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this Span<ulong> source)
    {
        return AverageCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>Compute Average in SIMD.</summary>
    public static double Average(this ReadOnlySpan<ulong> source)
    {
        return AverageCore(source);
    }

}


public static partial class SimdLinqExtensions
{
    /// <summary>Compute LongSum in SIMD.</summary>
    public static long LongSum(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static long LongSum(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static long LongSum(this Memory<int> source)
    {
        return LongSumCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static long LongSum(this ReadOnlyMemory<int> source)
    {
        return LongSumCore(source.Span);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static long LongSum(this Span<int> source)
    {
        return LongSumCore((ReadOnlySpan<int>)source);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static long LongSum(this ReadOnlySpan<int> source)
    {
        return LongSumCore(source);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static ulong LongSum(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static ulong LongSum(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return LongSumCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static ulong LongSum(this Memory<uint> source)
    {
        return LongSumCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static ulong LongSum(this ReadOnlyMemory<uint> source)
    {
        return LongSumCore(source.Span);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static ulong LongSum(this Span<uint> source)
    {
        return LongSumCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>Compute LongSum in SIMD.</summary>
    public static ulong LongSum(this ReadOnlySpan<uint> source)
    {
        return LongSumCore(source);
    }

}

