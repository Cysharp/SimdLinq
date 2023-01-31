using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using JM.LinqFaster.SIMD;
using NetFabric.Hyperlinq;
using SimdLinq;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Reflection;

var config = ManualConfig.CreateMinimumViable()
    .AddDiagnoser(MemoryDiagnoser.Default)
    .AddExporter(MarkdownExporter.Default)
    .AddJob(Job.Default.WithWarmupCount(1).WithIterationCount(1));

#if !DEBUG



// BenchmarkRunner.Run<IntSumBenchmark>(config, args);
//BenchmarkRunner.Run<IntMinBenchmark>(config, args);
//BenchmarkRunner.Run<LongMinBenchmark>(config, args);
//BenchmarkRunner.Run<DoubleMinBenchmark>(config, args);
//BenchmarkRunner.Run<IntContainsBenchmark>(config, args);

BenchmarkSwitcher.FromAssembly(Assembly.GetEntryAssembly()!).RunAllJoined(config);

#else

// _= Enumerable.Max((int[])null!);
//System.Linq.Enumerable.Min(Array.Empty<int>());
//_ = new IntMinBenchmark().SimdLinq();

#endif

public class IntSumBenchmark
{
    int[] source;

    public IntSumBenchmark()
    {
        source = Enumerable.Range(1, 10000).ToArray();

        var check = new[] { For(), LINQ(), SimdLinq(), LinqFasterSIMD(), Hyperlinq() }.Distinct().Count() == 1;
        if (!check)
        {
            throw new Exception("invalid result exists");
        }
    }

    [Benchmark]
    public int For()
    {
        var array = source;
        var sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    [Benchmark]
    public int LINQ()
    {
        return Enumerable.Sum(source);
    }

    [Benchmark]
    public int SimdLinq()
    {
        return SimdLinqExtensions.Sum(source);
    }

    [Benchmark]
    public int LinqFasterSIMD()
    {
        return source.SumS();
    }

    [Benchmark]
    public int Hyperlinq()
    {
        return source.AsValueEnumerable().Sum();
    }
}

public class IntMinBenchmark
{
    int[] source;

    public IntMinBenchmark()
    {
        var rand = new Random(123);
        source = Enumerable.Range(1, 10000).Select(_ => rand.Next()).ToArray();

        var check = new[] { For(), LINQ(), SimdLinq(), LinqFasterSIMD(), Hyperlinq() }.Distinct().Count() == 1;
        if (!check)
        {
            throw new Exception("invalid result exists");
        }
    }

    [Benchmark]
    public int For()
    {
        var array = source;
        var min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    [Benchmark]
    public int LINQ()
    {
        return Enumerable.Min(source);
    }

    [Benchmark]
    public int SimdLinq()
    {
        return SimdLinqExtensions.Min(source);
    }

    [Benchmark]
    public int LinqFasterSIMD()
    {
        return source.MinS();
    }

    [Benchmark]
    public int Hyperlinq()
    {
        return source.AsValueEnumerable().Min();
    }
}

public class LongMinBenchmark
{
    long[] source;

    public LongMinBenchmark()
    {
        var rand = new Random(123);
        source = Enumerable.Range(1, 10000).Select(_ => rand.NextInt64()).ToArray();

        var check = new[] { For(), LINQ(), SimdLinq(), LinqFasterSIMD(), Hyperlinq() }.Distinct().Count() == 1;
        if (!check)
        {
            throw new Exception("invalid result exists");
        }
    }

    [Benchmark]
    public long For()
    {
        var array = source;
        var min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    [Benchmark]
    public long LINQ()
    {
        return Enumerable.Min(source);
    }

    [Benchmark]
    public long SimdLinq()
    {
        return SimdLinqExtensions.Min(source);
    }

    [Benchmark]
    public long LinqFasterSIMD()
    {
        return source.MinS();
    }

    [Benchmark]
    public long Hyperlinq()
    {
        return source.AsValueEnumerable().Min();
    }
}

public class DoubleMinBenchmark
{
    double[] source;

    public DoubleMinBenchmark()
    {
        var rand = new Random(123);
        source = Enumerable.Range(1, 10000).Select(_ => rand.NextDouble()).ToArray();

        var check = new[] { For(), LINQ(), SimdLinq(), LinqFasterSIMD(), Hyperlinq() }.Distinct().Count() == 1;
        if (!check)
        {
            throw new Exception("invalid result exists");
        }
    }

    [Benchmark]
    public double For()
    {
        var array = source;
        var min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    [Benchmark]
    public double LINQ()
    {
        return Enumerable.Min(source);
    }

    [Benchmark]
    public double SimdLinq()
    {
        return SimdLinqExtensions.Min(source);
    }

    [Benchmark]
    public double LinqFasterSIMD()
    {
        return source.MinS();
    }

    [Benchmark]
    public double Hyperlinq()
    {
        return source.AsValueEnumerable().Min();
    }
}

public class IntContainsBenchmark
{
    int[] source;
    int target;
    public IntContainsBenchmark()
    {
        source = Enumerable.Range(1, 10000).ToArray();
        target = 8345;
        var check = new[] { For(), LINQ(), SimdLinq(), LinqFasterSIMD(), Hyperlinq() }.Distinct().Count() == 1;
        if (!check)
        {
            throw new Exception("invalid result exists");
        }
    }

    [Benchmark]
    public bool For()
    {
        var array = source;
        var t = target;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == t) return true;
        }
        return false;
    }

    [Benchmark]
    public bool LINQ()
    {
        return Enumerable.Contains(source, target);
    }

    [Benchmark]
    public bool SimdLinq()
    {
        return SimdLinqExtensions.Contains(source, target);
    }

    [Benchmark]
    public bool LinqFasterSIMD()
    {
        return source.ContainsS(target);
    }

    [Benchmark]
    public bool Hyperlinq()
    {
        return source.AsValueEnumerable().Contains(target);
    }


}
