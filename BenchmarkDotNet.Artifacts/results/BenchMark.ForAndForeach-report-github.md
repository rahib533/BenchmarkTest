``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.631 (20H2/October2020Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.204
  [Host]                   : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  String Benchmark Job 5.0 : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=String Benchmark Job 5.0  Runtime=.NET 5.0  

```
|      Method |      Mean |     Error |    StdDev |       Min |      Max |    Median | Ratio | RatioSD | Allocated |
|------------ |----------:|----------:|----------:|----------:|---------:|----------:|------:|--------:|----------:|
|     ForMeth | 0.7183 ns | 0.0824 ns | 0.1444 ns | 0.3524 ns | 1.003 ns | 0.7504 ns |  1.00 |    0.00 |         - |
| ForeachMeth | 8.1580 ns | 0.1850 ns | 0.1545 ns | 7.7892 ns | 8.357 ns | 8.1678 ns | 13.08 |    3.83 |         - |
