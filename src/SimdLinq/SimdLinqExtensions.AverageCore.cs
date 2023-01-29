using System.Numerics;

namespace SimdLinq;

public static partial class SimdLinqExtensions
{
     static T AverageCore<T>(ReadOnlySpan<T> source)
        where T : struct, INumber<T>
    {
        return T.CreateChecked(SumCore(source)) / T.CreateChecked(source.Length);
    }
}
