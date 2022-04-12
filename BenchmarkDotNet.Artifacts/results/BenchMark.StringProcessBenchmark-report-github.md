``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.631 (20H2/October2020Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.204
  [Host]                   : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  String Benchmark Job 5.0 : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                  Method |                      Job |       Runtime |        Mean |       Error |      StdDev |         Min |         Max |      Median | Ratio | RatioSD |      Gen 0 |     Gen 1 |     Allocated |
|------------------------ |------------------------- |-------------- |------------:|------------:|------------:|------------:|------------:|------------:|------:|--------:|-----------:|----------:|--------------:|
|                  Append | String Benchmark Job 3.1 | .NET Core 3.1 |          NA |          NA |          NA |          NA |          NA |          NA |     ? |       ? |          - |         - |             - |
| AppendWithStringBuilder | String Benchmark Job 3.1 | .NET Core 3.1 |          NA |          NA |          NA |          NA |          NA |          NA |     ? |       ? |          - |         - |             - |
|                         |                          |               |             |             |             |             |             |             |       |         |            |           |               |
| AppendWithStringBuilder | String Benchmark Job 5.0 |      .NET 5.0 |    128.8 μs |     1.81 μs |     3.07 μs |    124.3 μs |    140.8 μs |    128.0 μs | 0.004 |    0.00 |    64.2090 |   14.6484 |     404,040 B |
|                  Append | String Benchmark Job 5.0 |      .NET 5.0 | 29,626.5 μs | 1,618.21 μs | 4,771.33 μs | 21,686.3 μs | 43,081.3 μs | 30,192.5 μs | 1.000 |    0.00 | 60125.0000 | 8937.5000 | 379,445,736 B |

Benchmarks with issues:
  StringProcessBenchmark.Append: String Benchmark Job 3.1(Runtime=.NET Core 3.1)
  StringProcessBenchmark.AppendWithStringBuilder: String Benchmark Job 3.1(Runtime=.NET Core 3.1)
