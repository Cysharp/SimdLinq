namespace SimdLinq;

using System.Runtime.InteropServices;

// SequenceEqual<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> other) and if T is bitwise equatable, using SIMD.

public static partial class SimdLinqExtensions
{
    public static bool SequenceEqual(byte[] first, byte[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(byte[] first, ReadOnlySpan<byte> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<byte> first, List<byte> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<byte> first, ReadOnlySpan<byte> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<byte>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<byte> first, Memory<byte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<byte>)first.Span, (ReadOnlySpan<byte>)second.Span);
    }

    public static bool SequenceEqual(Memory<byte> first, ReadOnlySpan<byte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<byte>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<byte> first, ReadOnlyMemory<byte> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<byte> first, ReadOnlySpan<byte> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<byte> first, Span<byte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<byte>)first, (ReadOnlySpan<byte>)second);
    }

    public static bool SequenceEqual(Span<byte> first, ReadOnlySpan<byte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<byte>)first, second);
    }

    public static bool SequenceEqual(sbyte[] first, sbyte[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(sbyte[] first, ReadOnlySpan<sbyte> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<sbyte> first, List<sbyte> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<sbyte> first, ReadOnlySpan<sbyte> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<sbyte>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<sbyte> first, Memory<sbyte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<sbyte>)first.Span, (ReadOnlySpan<sbyte>)second.Span);
    }

    public static bool SequenceEqual(Memory<sbyte> first, ReadOnlySpan<sbyte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<sbyte>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<sbyte> first, ReadOnlyMemory<sbyte> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<sbyte> first, ReadOnlySpan<sbyte> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<sbyte> first, Span<sbyte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<sbyte>)first, (ReadOnlySpan<sbyte>)second);
    }

    public static bool SequenceEqual(Span<sbyte> first, ReadOnlySpan<sbyte> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<sbyte>)first, second);
    }

    public static bool SequenceEqual(short[] first, short[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(short[] first, ReadOnlySpan<short> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<short> first, List<short> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<short>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<short> first, ReadOnlySpan<short> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<short>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<short> first, Memory<short> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<short>)first.Span, (ReadOnlySpan<short>)second.Span);
    }

    public static bool SequenceEqual(Memory<short> first, ReadOnlySpan<short> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<short>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<short> first, ReadOnlyMemory<short> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<short> first, ReadOnlySpan<short> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<short> first, Span<short> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<short>)first, (ReadOnlySpan<short>)second);
    }

    public static bool SequenceEqual(Span<short> first, ReadOnlySpan<short> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<short>)first, second);
    }

    public static bool SequenceEqual(ushort[] first, ushort[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(ushort[] first, ReadOnlySpan<ushort> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<ushort> first, List<ushort> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<ushort> first, ReadOnlySpan<ushort> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ushort>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<ushort> first, Memory<ushort> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ushort>)first.Span, (ReadOnlySpan<ushort>)second.Span);
    }

    public static bool SequenceEqual(Memory<ushort> first, ReadOnlySpan<ushort> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ushort>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<ushort> first, ReadOnlyMemory<ushort> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<ushort> first, ReadOnlySpan<ushort> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<ushort> first, Span<ushort> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ushort>)first, (ReadOnlySpan<ushort>)second);
    }

    public static bool SequenceEqual(Span<ushort> first, ReadOnlySpan<ushort> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ushort>)first, second);
    }

    public static bool SequenceEqual(int[] first, int[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(int[] first, ReadOnlySpan<int> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<int> first, List<int> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<int>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<int> first, ReadOnlySpan<int> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<int>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<int> first, Memory<int> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<int>)first.Span, (ReadOnlySpan<int>)second.Span);
    }

    public static bool SequenceEqual(Memory<int> first, ReadOnlySpan<int> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<int>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<int> first, ReadOnlyMemory<int> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<int> first, ReadOnlySpan<int> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<int> first, Span<int> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<int>)first, (ReadOnlySpan<int>)second);
    }

    public static bool SequenceEqual(Span<int> first, ReadOnlySpan<int> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<int>)first, second);
    }

    public static bool SequenceEqual(uint[] first, uint[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(uint[] first, ReadOnlySpan<uint> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<uint> first, List<uint> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<uint> first, ReadOnlySpan<uint> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<uint>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<uint> first, Memory<uint> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<uint>)first.Span, (ReadOnlySpan<uint>)second.Span);
    }

    public static bool SequenceEqual(Memory<uint> first, ReadOnlySpan<uint> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<uint>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<uint> first, ReadOnlyMemory<uint> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<uint> first, ReadOnlySpan<uint> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<uint> first, Span<uint> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<uint>)first, (ReadOnlySpan<uint>)second);
    }

    public static bool SequenceEqual(Span<uint> first, ReadOnlySpan<uint> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<uint>)first, second);
    }

    public static bool SequenceEqual(long[] first, long[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(long[] first, ReadOnlySpan<long> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<long> first, List<long> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<long>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<long> first, ReadOnlySpan<long> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<long>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<long> first, Memory<long> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<long>)first.Span, (ReadOnlySpan<long>)second.Span);
    }

    public static bool SequenceEqual(Memory<long> first, ReadOnlySpan<long> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<long>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<long> first, ReadOnlyMemory<long> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<long> first, ReadOnlySpan<long> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<long> first, Span<long> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<long>)first, (ReadOnlySpan<long>)second);
    }

    public static bool SequenceEqual(Span<long> first, ReadOnlySpan<long> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<long>)first, second);
    }

    public static bool SequenceEqual(ulong[] first, ulong[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(ulong[] first, ReadOnlySpan<ulong> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<ulong> first, List<ulong> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<ulong> first, ReadOnlySpan<ulong> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ulong>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<ulong> first, Memory<ulong> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ulong>)first.Span, (ReadOnlySpan<ulong>)second.Span);
    }

    public static bool SequenceEqual(Memory<ulong> first, ReadOnlySpan<ulong> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ulong>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<ulong> first, ReadOnlyMemory<ulong> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<ulong> first, ReadOnlySpan<ulong> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<ulong> first, Span<ulong> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ulong>)first, (ReadOnlySpan<ulong>)second);
    }

    public static bool SequenceEqual(Span<ulong> first, ReadOnlySpan<ulong> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<ulong>)first, second);
    }

    public static bool SequenceEqual(float[] first, float[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(float[] first, ReadOnlySpan<float> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<float> first, List<float> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<float>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<float> first, ReadOnlySpan<float> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<float>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<float> first, Memory<float> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<float>)first.Span, (ReadOnlySpan<float>)second.Span);
    }

    public static bool SequenceEqual(Memory<float> first, ReadOnlySpan<float> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<float>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<float> first, ReadOnlyMemory<float> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<float> first, ReadOnlySpan<float> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<float> first, Span<float> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<float>)first, (ReadOnlySpan<float>)second);
    }

    public static bool SequenceEqual(Span<float> first, ReadOnlySpan<float> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<float>)first, second);
    }

    public static bool SequenceEqual(double[] first, double[] second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second.AsSpan());
    }

    public static bool SequenceEqual(double[] first, ReadOnlySpan<double> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual(first.AsSpan(), second);
    }

    public static bool SequenceEqual(List<double> first, List<double> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(first), (ReadOnlySpan<double>)CollectionsMarshal.AsSpan(second));
    }

    public static bool SequenceEqual(List<double> first, ReadOnlySpan<double> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<double>)CollectionsMarshal.AsSpan(first), second);
    }

    public static bool SequenceEqual(Memory<double> first, Memory<double> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<double>)first.Span, (ReadOnlySpan<double>)second.Span);
    }

    public static bool SequenceEqual(Memory<double> first, ReadOnlySpan<double> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<double>)first.Span, second);
    }

    public static bool SequenceEqual(ReadOnlyMemory<double> first, ReadOnlyMemory<double> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second.Span);
    }

    public static bool SequenceEqual(ReadOnlyMemory<double> first, ReadOnlySpan<double> second)
    {
        return MemoryExtensions.SequenceEqual(first.Span, second);
    }

    public static bool SequenceEqual(Span<double> first, Span<double> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<double>)first, (ReadOnlySpan<double>)second);
    }

    public static bool SequenceEqual(Span<double> first, ReadOnlySpan<double> second)
    {
        return MemoryExtensions.SequenceEqual((ReadOnlySpan<double>)first, second);
    }

}
