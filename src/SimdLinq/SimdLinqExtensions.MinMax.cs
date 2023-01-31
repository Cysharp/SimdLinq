namespace SimdLinq;

using System.Runtime.InteropServices;

public static partial class SimdLinqExtensions
{
    /// <summary>Compute Min in SIMD.</summary>
    public static byte Min(this byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<byte>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static byte Min(this List<byte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static byte Min(this Memory<byte> source)
    {
        return MinCore((ReadOnlySpan<byte>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static byte Min(this ReadOnlyMemory<byte> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static byte Min(this Span<byte> source)
    {
        return MinCore((ReadOnlySpan<byte>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static byte Min(this ReadOnlySpan<byte> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static sbyte Min(this sbyte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<sbyte>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static sbyte Min(this List<sbyte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static sbyte Min(this Memory<sbyte> source)
    {
        return MinCore((ReadOnlySpan<sbyte>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static sbyte Min(this ReadOnlyMemory<sbyte> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static sbyte Min(this Span<sbyte> source)
    {
        return MinCore((ReadOnlySpan<sbyte>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static sbyte Min(this ReadOnlySpan<sbyte> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static short Min(this short[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<short>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static short Min(this List<short> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static short Min(this Memory<short> source)
    {
        return MinCore((ReadOnlySpan<short>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static short Min(this ReadOnlyMemory<short> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static short Min(this Span<short> source)
    {
        return MinCore((ReadOnlySpan<short>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static short Min(this ReadOnlySpan<short> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ushort Min(this ushort[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<ushort>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ushort Min(this List<ushort> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ushort Min(this Memory<ushort> source)
    {
        return MinCore((ReadOnlySpan<ushort>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ushort Min(this ReadOnlyMemory<ushort> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ushort Min(this Span<ushort> source)
    {
        return MinCore((ReadOnlySpan<ushort>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ushort Min(this ReadOnlySpan<ushort> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static int Min(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static int Min(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static int Min(this Memory<int> source)
    {
        return MinCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static int Min(this ReadOnlyMemory<int> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static int Min(this Span<int> source)
    {
        return MinCore((ReadOnlySpan<int>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static int Min(this ReadOnlySpan<int> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static uint Min(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static uint Min(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static uint Min(this Memory<uint> source)
    {
        return MinCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static uint Min(this ReadOnlyMemory<uint> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static uint Min(this Span<uint> source)
    {
        return MinCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static uint Min(this ReadOnlySpan<uint> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static long Min(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static long Min(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static long Min(this Memory<long> source)
    {
        return MinCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static long Min(this ReadOnlyMemory<long> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static long Min(this Span<long> source)
    {
        return MinCore((ReadOnlySpan<long>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static long Min(this ReadOnlySpan<long> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ulong Min(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ulong Min(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ulong Min(this Memory<ulong> source)
    {
        return MinCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ulong Min(this ReadOnlyMemory<ulong> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ulong Min(this Span<ulong> source)
    {
        return MinCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static ulong Min(this ReadOnlySpan<ulong> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static float Min(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static float Min(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static float Min(this Memory<float> source)
    {
        return MinCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static float Min(this ReadOnlyMemory<float> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static float Min(this Span<float> source)
    {
        return MinCore((ReadOnlySpan<float>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static float Min(this ReadOnlySpan<float> source)
    {
        return MinCore(source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static double Min(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static double Min(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static double Min(this Memory<double> source)
    {
        return MinCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static double Min(this ReadOnlyMemory<double> source)
    {
        return MinCore(source.Span);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static double Min(this Span<double> source)
    {
        return MinCore((ReadOnlySpan<double>)source);
    }

    /// <summary>Compute Min in SIMD.</summary>
    public static double Min(this ReadOnlySpan<double> source)
    {
        return MinCore(source);
    }

}


public static partial class SimdLinqExtensions
{
    /// <summary>Compute Max in SIMD.</summary>
    public static byte Max(this byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<byte>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static byte Max(this List<byte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static byte Max(this Memory<byte> source)
    {
        return MaxCore((ReadOnlySpan<byte>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static byte Max(this ReadOnlyMemory<byte> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static byte Max(this Span<byte> source)
    {
        return MaxCore((ReadOnlySpan<byte>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static byte Max(this ReadOnlySpan<byte> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static sbyte Max(this sbyte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<sbyte>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static sbyte Max(this List<sbyte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static sbyte Max(this Memory<sbyte> source)
    {
        return MaxCore((ReadOnlySpan<sbyte>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static sbyte Max(this ReadOnlyMemory<sbyte> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static sbyte Max(this Span<sbyte> source)
    {
        return MaxCore((ReadOnlySpan<sbyte>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static sbyte Max(this ReadOnlySpan<sbyte> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static short Max(this short[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<short>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static short Max(this List<short> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static short Max(this Memory<short> source)
    {
        return MaxCore((ReadOnlySpan<short>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static short Max(this ReadOnlyMemory<short> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static short Max(this Span<short> source)
    {
        return MaxCore((ReadOnlySpan<short>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static short Max(this ReadOnlySpan<short> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ushort Max(this ushort[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<ushort>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ushort Max(this List<ushort> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ushort Max(this Memory<ushort> source)
    {
        return MaxCore((ReadOnlySpan<ushort>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ushort Max(this ReadOnlyMemory<ushort> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ushort Max(this Span<ushort> source)
    {
        return MaxCore((ReadOnlySpan<ushort>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ushort Max(this ReadOnlySpan<ushort> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static int Max(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static int Max(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static int Max(this Memory<int> source)
    {
        return MaxCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static int Max(this ReadOnlyMemory<int> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static int Max(this Span<int> source)
    {
        return MaxCore((ReadOnlySpan<int>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static int Max(this ReadOnlySpan<int> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static uint Max(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static uint Max(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static uint Max(this Memory<uint> source)
    {
        return MaxCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static uint Max(this ReadOnlyMemory<uint> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static uint Max(this Span<uint> source)
    {
        return MaxCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static uint Max(this ReadOnlySpan<uint> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static long Max(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static long Max(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static long Max(this Memory<long> source)
    {
        return MaxCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static long Max(this ReadOnlyMemory<long> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static long Max(this Span<long> source)
    {
        return MaxCore((ReadOnlySpan<long>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static long Max(this ReadOnlySpan<long> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ulong Max(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ulong Max(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ulong Max(this Memory<ulong> source)
    {
        return MaxCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ulong Max(this ReadOnlyMemory<ulong> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ulong Max(this Span<ulong> source)
    {
        return MaxCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static ulong Max(this ReadOnlySpan<ulong> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static float Max(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static float Max(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static float Max(this Memory<float> source)
    {
        return MaxCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static float Max(this ReadOnlyMemory<float> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static float Max(this Span<float> source)
    {
        return MaxCore((ReadOnlySpan<float>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static float Max(this ReadOnlySpan<float> source)
    {
        return MaxCore(source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static double Max(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static double Max(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MaxCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static double Max(this Memory<double> source)
    {
        return MaxCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static double Max(this ReadOnlyMemory<double> source)
    {
        return MaxCore(source.Span);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static double Max(this Span<double> source)
    {
        return MaxCore((ReadOnlySpan<double>)source);
    }

    /// <summary>Compute Max in SIMD.</summary>
    public static double Max(this ReadOnlySpan<double> source)
    {
        return MaxCore(source);
    }

}


public static partial class SimdLinqExtensions
{
    /// <summary>Compute MinMax in SIMD.</summary>
    public static (byte Min, byte Max) MinMax(this byte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<byte>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (byte Min, byte Max) MinMax(this List<byte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (byte Min, byte Max) MinMax(this Memory<byte> source)
    {
        return MinMaxCore((ReadOnlySpan<byte>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (byte Min, byte Max) MinMax(this ReadOnlyMemory<byte> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (byte Min, byte Max) MinMax(this Span<byte> source)
    {
        return MinMaxCore((ReadOnlySpan<byte>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (byte Min, byte Max) MinMax(this ReadOnlySpan<byte> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (sbyte Min, sbyte Max) MinMax(this sbyte[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<sbyte>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (sbyte Min, sbyte Max) MinMax(this List<sbyte> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (sbyte Min, sbyte Max) MinMax(this Memory<sbyte> source)
    {
        return MinMaxCore((ReadOnlySpan<sbyte>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (sbyte Min, sbyte Max) MinMax(this ReadOnlyMemory<sbyte> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (sbyte Min, sbyte Max) MinMax(this Span<sbyte> source)
    {
        return MinMaxCore((ReadOnlySpan<sbyte>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (sbyte Min, sbyte Max) MinMax(this ReadOnlySpan<sbyte> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (short Min, short Max) MinMax(this short[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<short>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (short Min, short Max) MinMax(this List<short> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (short Min, short Max) MinMax(this Memory<short> source)
    {
        return MinMaxCore((ReadOnlySpan<short>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (short Min, short Max) MinMax(this ReadOnlyMemory<short> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (short Min, short Max) MinMax(this Span<short> source)
    {
        return MinMaxCore((ReadOnlySpan<short>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (short Min, short Max) MinMax(this ReadOnlySpan<short> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ushort Min, ushort Max) MinMax(this ushort[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<ushort>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ushort Min, ushort Max) MinMax(this List<ushort> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ushort Min, ushort Max) MinMax(this Memory<ushort> source)
    {
        return MinMaxCore((ReadOnlySpan<ushort>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ushort Min, ushort Max) MinMax(this ReadOnlyMemory<ushort> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ushort Min, ushort Max) MinMax(this Span<ushort> source)
    {
        return MinMaxCore((ReadOnlySpan<ushort>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ushort Min, ushort Max) MinMax(this ReadOnlySpan<ushort> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (int Min, int Max) MinMax(this int[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<int>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (int Min, int Max) MinMax(this List<int> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (int Min, int Max) MinMax(this Memory<int> source)
    {
        return MinMaxCore((ReadOnlySpan<int>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (int Min, int Max) MinMax(this ReadOnlyMemory<int> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (int Min, int Max) MinMax(this Span<int> source)
    {
        return MinMaxCore((ReadOnlySpan<int>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (int Min, int Max) MinMax(this ReadOnlySpan<int> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (uint Min, uint Max) MinMax(this uint[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<uint>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (uint Min, uint Max) MinMax(this List<uint> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (uint Min, uint Max) MinMax(this Memory<uint> source)
    {
        return MinMaxCore((ReadOnlySpan<uint>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (uint Min, uint Max) MinMax(this ReadOnlyMemory<uint> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (uint Min, uint Max) MinMax(this Span<uint> source)
    {
        return MinMaxCore((ReadOnlySpan<uint>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (uint Min, uint Max) MinMax(this ReadOnlySpan<uint> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (long Min, long Max) MinMax(this long[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<long>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (long Min, long Max) MinMax(this List<long> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (long Min, long Max) MinMax(this Memory<long> source)
    {
        return MinMaxCore((ReadOnlySpan<long>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (long Min, long Max) MinMax(this ReadOnlyMemory<long> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (long Min, long Max) MinMax(this Span<long> source)
    {
        return MinMaxCore((ReadOnlySpan<long>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (long Min, long Max) MinMax(this ReadOnlySpan<long> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ulong Min, ulong Max) MinMax(this ulong[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<ulong>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ulong Min, ulong Max) MinMax(this List<ulong> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ulong Min, ulong Max) MinMax(this Memory<ulong> source)
    {
        return MinMaxCore((ReadOnlySpan<ulong>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ulong Min, ulong Max) MinMax(this ReadOnlyMemory<ulong> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ulong Min, ulong Max) MinMax(this Span<ulong> source)
    {
        return MinMaxCore((ReadOnlySpan<ulong>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (ulong Min, ulong Max) MinMax(this ReadOnlySpan<ulong> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (float Min, float Max) MinMax(this float[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<float>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (float Min, float Max) MinMax(this List<float> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (float Min, float Max) MinMax(this Memory<float> source)
    {
        return MinMaxCore((ReadOnlySpan<float>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (float Min, float Max) MinMax(this ReadOnlyMemory<float> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (float Min, float Max) MinMax(this Span<float> source)
    {
        return MinMaxCore((ReadOnlySpan<float>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (float Min, float Max) MinMax(this ReadOnlySpan<float> source)
    {
        return MinMaxCore(source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (double Min, double Max) MinMax(this double[] source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore(new ReadOnlySpan<double>(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (double Min, double Max) MinMax(this List<double> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return MinMaxCore((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(source));
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (double Min, double Max) MinMax(this Memory<double> source)
    {
        return MinMaxCore((ReadOnlySpan<double>)source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (double Min, double Max) MinMax(this ReadOnlyMemory<double> source)
    {
        return MinMaxCore(source.Span);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (double Min, double Max) MinMax(this Span<double> source)
    {
        return MinMaxCore((ReadOnlySpan<double>)source);
    }

    /// <summary>Compute MinMax in SIMD.</summary>
    public static (double Min, double Max) MinMax(this ReadOnlySpan<double> source)
    {
        return MinMaxCore(source);
    }

}

