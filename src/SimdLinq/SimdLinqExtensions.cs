using System.Diagnostics.CodeAnalysis;

namespace SimdLinq;

public static partial class SimdLinqExtensions
{
    [DoesNotReturn]
    static void ThrowNoElements()
    {
        throw new InvalidOperationException("Sequence contains no elements");
    }
}
