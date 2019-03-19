This is a benchmark project for the following issue:

:link: [Large time difference between the same methods but in different bodies](https://developercommunity.visualstudio.com/content/problem/490297/large-time-difference-between-the-same-methods-but.html)

The project was created to demonstrate the process for setting up an accurate benchmark for a relatively simple scenario. Additional information can be found in the [BenchmarkDotNet documentation](https://benchmarkdotnet.org/).

### Results (.NET Framework 4.7.2)

```
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.379 (1809/October2018Update/Redstone5)
AMD Ryzen Threadripper 2990WX, 1 CPU, 64 logical and 32 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3362.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3362.0


|           Method |      Mean |     Error |    StdDev |
|----------------- |----------:|----------:|----------:|
| ExpressionBodied | 0.7982 ns | 0.0074 ns | 0.0069 ns |
|      BlockBodied | 0.8051 ns | 0.0094 ns | 0.0083 ns |
```

### Results (.NET Core)

```
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.379 (1809/October2018Update/Redstone5)
AMD Ryzen Threadripper 2990WX, 1 CPU, 64 logical and 32 physical cores
.NET Core SDK=3.0.100-preview3-010431
  [Host]     : .NET Core 2.1.8 (CoreCLR 4.6.27317.03, CoreFX 4.6.27317.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.8 (CoreCLR 4.6.27317.03, CoreFX 4.6.27317.03), 64bit RyuJIT


|           Method |      Mean |     Error |    StdDev |
|----------------- |----------:|----------:|----------:|
| ExpressionBodied | 0.8025 ns | 0.0087 ns | 0.0081 ns |
|      BlockBodied | 0.8018 ns | 0.0062 ns | 0.0055 ns |
```

### Conclusion

Based on the benchmarking results, there is no measurable difference in performance between block-bodied members and expression-bodied members.
