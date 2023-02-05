# SimdLinq
[![GitHub Actions](https://github.com/Cysharp/SimdLinq/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/SimdLinq/actions) [![Releases](https://img.shields.io/github/release/Cysharp/SimdLinq.svg)](https://github.com/Cysharp/SimdLinq/releases)

SimdLinq is a drop-in replacement of LINQ aggregation operations(`Sum`, `Average`, `Min`, `Max`) extremely faster with SIMD.

![image](https://user-images.githubusercontent.com/46207/215410106-b68d8567-5abf-4aa4-a050-a803b1913187.png)

[.NET 7 LINQ supports SIMD](https://devblogs.microsoft.com/dotnet/performance_improvements_in_net_7/#linq) but it is very limited, due to compatibility and safety issues, it is only enabled for `int[]` `Average`, `Min`, `Max` and `long[]` `Min`, `Max`.

SimdLinq accelerates many methods (`Sum`, `LongSum`, `Average`, `Min`, `Max`, `MinMax`, `Contains`, `SequenceEqual`) and types (`byte`, `sbyte`, `short`, `ushort`, ` int`, `uint`, `long`, `ulong`, `float`, `double`). It can also be used with `List<T>`, `Span<T>`, `ReadOnlySpan<T>`, `Memory<T>`, `ReadOnlyMemory<T>` in addition to `T[]`.

Using the overload resolution priority, all target methods are automatically SIMD by simply referencing the library and setting global using.

Quick Start
---
This library is distributed via NuGet.

> PM> Install-Package [SimdLinq](https://www.nuget.org/packages/SimdLinq)

Note that this library requires **.NET 7** or above because this library uses static abstract members and the new cross platform **.NET 7** SIMD Api.

```csharp
using SimdLinq; // enable SimdLinq extension methods

var array = Enumerable.Range(1, 100000).ToArray();

var sum = array.Sum(); // uses SimdLinqExtensions.Sum
```

To enable SimdLinq per file, add the `using SimdLinq;` using directive. To enable SimdLinq across the project, use global usings in the csproj file.

```xml
<ItemGroup>
    <Using Include="SimdLinq" />
</ItemGroup>
```

`SimdLinqExtensions` has methods for concrete data types, like `int[]` or `Span<double>`, with the same names as LINQ's methods. If a method is eligible for SIMD optimization (such as the Sum of int[]), the `SimdLinqExtensions` method will be used for improved performance.

Unlike base LINQ, SimdLinq supports `Span<T>`, allowing you to call methods such as `Sum`, `Min`, etc. on `Span<T>` or `ReadOnlySpan<T>` collections.

```csharp
(double Min, double Max) GetMinMax(Span<double> span)
{
    return span.MinMax();
}
```

`MinMax` is an original SimdLinq extension, that returns a tuple of `Min` and `Max`.

Compatibility
---
One of the reasons why LINQ's SIMD support in .NET 7 is incomplete, is compatibility. SimdLinq prioritises performance over some safety features and full compatibility with LINQ. Please note the following differences.

### Sum/Average

LINQ Sum is `checked` but SimdLinq is `unchecked`(SIMD operation is not supported overflow). To reduce the risk of overflow, `Sum` and `Average` only support types that are 32-bit or higher(`int`, `long`, `uint`, `ulong`, `double`, `float`).

SimdLinq provides `LongSum` for `int` and `uint`, that returns `long`/`ulong` so avoid overflow.

### float/double

Unlike LINQ, SimdLinq does not check for NaN in float/double Min/Max calculations. Additionally, the order of calculation for Sum is not sequential, leading to slight differences in floating-point operations compared to regular LINQ. For instance, LINQ returns 1.5710588F, while SimdLinq returns 1.5710589F. If compatibility is not a concern, this difference is not significant, but be aware of potential small tolerance differences.

Supported collections
---
`T[]`, `List<T>`, `Span<T>`, `Memory<T>`, `ReadOnlyMemory<T>`, `Span<T>`, `ReadOnlySpan<T>`.

Supported methods
---
* `Sum` for `int`, `uint`, `long`, `ulong`, `float`, `double`
* `LongSum` for `int`, `uint`
* `Average` for `int`, `uint`, `long`, `ulong`, `float`, `double`
* `Min` for `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`
* `Max` for `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`
* `MinMax` for `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`
* `Contains` for `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`
* `SequenceEqual` for `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`

SoA
---
SIMD with LINQ requires primitive array(or Span). [Cysharp/StructureOfArraysGenerator](https://github.com/Cysharp/StructureOfArraysGenerator) makes easy to create SoA array to use SIMD easily.

License
---
This library is licensed under the MIT License.
