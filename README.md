# SimdLinq
[![GitHub Actions](https://github.com/Cysharp/SimdLinq/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/SimdLinq/actions) [![Releases](https://img.shields.io/github/release/Cysharp/SimdLinq.svg)](https://github.com/Cysharp/SimdLinq/releases)

SimdLinq is a drop-in replacement of LINQ aggregation operations(`Sum`, `Average`, `Min`, `Max`) extremely faster with SIMD.

![image](https://user-images.githubusercontent.com/46207/215410106-b68d8567-5abf-4aa4-a050-a803b1913187.png)

[.NET 7 LINQ supports SIMD](https://devblogs.microsoft.com/dotnet/performance_improvements_in_net_7/#linq) but it is very limited, due to compatibility and safety issues, it is only enabled for `int[]` `Average`, `Min`, `Max` and `long[]` `Min`, `Max`.

SimdLinq accelerates many methods (`Sum`, `Average`, `Min`, `Max`, `MinMax`, `Contains`, `SequenceEqual`) and types (`byte`, `sbyte`, `short`, `ushort`, ` int`, `uint`, `long`, `ulong`, `float`, `double`). It can also be used with `List<T>`, `Span<T>`, `ReadOnlySpan<T>`, `Memory<T>`, `ReadOnlyMemory<T>` in addition to `T[]`.

Using the overload resolution priority, all target methods are automatically SIMD by simply referencing the library and setting global using.

Quick Start
---
This library is distributed via NuGet.

> PM> Install-Package [SimdLinq](https://www.nuget.org/packages/SimdLinq)

Currently supporting target framework is only **.NET 7** or above because this library using static abstract members and .NET 7 SIMD API improvement.

```csharp
using SimdLinq; // enable SimdLinq extension methods

var array = Enumerable.Range(1, 100000).ToArray();

var sum = array.Sum(); // used SimdLinqExtensions.Sum
```

To enable SimdLinq per file, uses `using SimdLinq;` namespace. To enable SimdLinq per project, uses global usings in csproj.

```xml
<ItemGroup>
    <Using Include="SimdLinq" />
</ItemGroup>
```

`SimdLinqExtensions` has methods for concrete types(`int[]`, `Span<double`, etc...) that same name defined in LINQ, so that if a method is used that can effectively use SIMD (such as `Sum` of `int[]`), it will be executed.

`Span<T>` has no LINQ methods but SimdLinq has it so you can call `Sum`, `Min` etc in `Span<T>`/`ReadOnlySpan<T>`.

```csharp
(double Min, double Max) GetMinMax(Span<double> span)
{
    return span.MinMax();
}
```

`MinMax` is a original extension of SimdLinq, that returns tuple of `Min` and `Max`.

Compatibility
---
One of the reasons why LINQ's SIMD support in .NET 7 is incomplete, is compatibility. SimdLinq top priority is SIMD enablement to fastest operation so sacrifices compatibility and some safety features. Please note the following.

### Sum/Average

LINQ Sum is `checked` but SimdLinq is `unchecked`(SIMD operation is not supported overflow). To reduce the risk of overflow, `Sum` and `Average` supported types are 32-bit or higher(`int`, `long`, `uint`, `ulong`, `double`, `float`).

### float/double

LINQ Min/Max of float/double checks `NaN` but SimdLinq does not. Also, the order in which Sum is calculated is not sequential. This results in floating-point operations that are different from those in regular LINQ. For example, with LINQ `1.5710588F` but SIMD `1.5710589F`. If compatibility is not important, this is not a problem, but be aware that very small tolerance can occur.

Supporting collection
---
`T[]`, `List<T>`, `Span<T>`, `ReadOnlySpan<T>`, `Memory<T>`, `ReadOnlyMemory<T>`, `Span<T>`, `ReadOnlySpan<T>`.

Supporting methods
---
* `Sum` for `int`, `uint`, `long`, `ulong`, `float`, `double`
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
