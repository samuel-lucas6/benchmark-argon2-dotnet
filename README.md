# BenchmarkArgon2.NET
Benchmark [Argon2](https://www.rfc-editor.org/rfc/rfc9106.html) in [Libsodium](https://doc.libsodium.org/password_hashing/default_phf), [Monocypher](https://monocypher.org/manual/argon2), [Konscious.Security.Cryptography](https://github.com/kmaragon/Konscious.Security.Cryptography), and/or [Isopoh.Cryptography](https://github.com/mheyman/Isopoh.Cryptography.Argon2) using [BenchmarkDotNet](https://benchmarkdotnet.org/index.html) to find suitable parameters.

## Instructions
1. Go to the `Program.cs` file and comment out (`//`) the libraries you don't want to benchmark.
2. Edit the Argon2 parameters in the `Config.cs` file.
3. Build the project in `Release` mode.
4. Close programs running in the background (and plug in your charger if using a laptop).
5. Run the executable as admin/root (and leave your computer alone until the benchmark is done).
6. View and back up the results in the `\bin\Release\net8.0\BenchmarkDotNet.Artifacts\results` folder.

> [!TIP]
> Run the benchmark on multiple devices if possible. For example, a desktop and a laptop.

## Desktop Results
### Setup
```
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)

Intel Core i5-9600K CPU 3.70GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores

.NET SDK 8.0.201
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```

### Libsodium
| Method             | MemorySize | Iterations | Mean        | Error    | StdDev   |
|------------------- |----------- |----------- |------------:|---------:|---------:|
| **Libsodium.Argon2id** | **32 MiB**   | **1**          |    **16.26 ms** | **0.323 ms** | **0.385 ms** |
| **Libsodium.Argon2id** | **32 MiB**   | **3**          |    **37.13 ms** | **0.222 ms** | **0.197 ms** |
| **Libsodium.Argon2id** | **32 MiB**   | **6**          |    **69.81 ms** | **0.302 ms** | **0.267 ms** |
| **Libsodium.Argon2id** | **64 MiB**   | **1**          |    **31.44 ms** | **0.075 ms** | **0.070 ms** |
| **Libsodium.Argon2id** | **64 MiB**   | **3**          |    **76.07 ms** | **0.111 ms** | **0.099 ms** |
| **Libsodium.Argon2id** | **64 MiB**   | **6**          |   **144.87 ms** | **0.646 ms** | **0.604 ms** |
| **Libsodium.Argon2id** | **128 MiB**  | **1**          |    **65.65 ms** | **0.290 ms** | **0.272 ms** |
| **Libsodium.Argon2id** | **128 MiB**  | **3**          |   **158.45 ms** | **0.305 ms** | **0.255 ms** |
| **Libsodium.Argon2id** | **128 MiB**  | **6**          |   **303.28 ms** | **1.166 ms** | **1.033 ms** |
| **Libsodium.Argon2id** | **256 MiB**  | **1**          |   **134.05 ms** | **0.355 ms** | **0.315 ms** |
| **Libsodium.Argon2id** | **256 MiB**  | **3**          |   **330.68 ms** | **0.430 ms** | **0.359 ms** |
| **Libsodium.Argon2id** | **256 MiB**  | **6**          |   **629.11 ms** | **3.017 ms** | **2.519 ms** |
| **Libsodium.Argon2id** | **512 MiB**  | **1**          |   **269.15 ms** | **1.899 ms** | **1.586 ms** |
| **Libsodium.Argon2id** | **512 MiB**  | **3**          |   **688.62 ms** | **0.818 ms** | **0.683 ms** |
| **Libsodium.Argon2id** | **512 MiB**  | **6**          | **1,289.81 ms** | **4.065 ms** | **3.394 ms** |
| **Libsodium.Argon2id** | **768 MiB**  | **1**          |   **409.73 ms** | **0.408 ms** | **0.382 ms** |
| **Libsodium.Argon2id** | **768 MiB**  | **3**          | **1,036.60 ms** | **1.974 ms** | **1.846 ms** |
| **Libsodium.Argon2id** | **768 MiB**  | **6**          | **1,976.16 ms** | **2.978 ms** | **2.487 ms** |
| **Libsodium.Argon2id** | **1 GiB** | **1**          |   **555.99 ms** | **0.508 ms** | **0.450 ms** |
| **Libsodium.Argon2id** | **1 GiB** | **3**          | **1,427.73 ms** | **0.913 ms** | **0.763 ms** |
| **Libsodium.Argon2id** | **1 GiB** | **6**          | **2,674.41 ms** | **1.579 ms** | **1.477 ms** |

### Monocypher
| Method            | MemorySize | Iterations | Mean        | Error    | StdDev   |
|------------------ |----------- |----------- |------------:|---------:|---------:|
| **Monocypher.Argon2id** | **32 MiB**   | **1**          |    **26.37 ms** | **0.516 ms** | **0.530 ms** |
| **Monocypher.Argon2id** | **32 MiB**   | **3**          |    **70.89 ms** | **0.064 ms** | **0.060 ms** |
| **Monocypher.Argon2id** | **32 MiB**   | **6**          |   **141.42 ms** | **0.209 ms** | **0.163 ms** |
| **Monocypher.Argon2id** | **64 MiB**   | **1**          |    **49.47 ms** | **0.029 ms** | **0.024 ms** |
| **Monocypher.Argon2id** | **64 MiB**   | **3**          |   **145.33 ms** | **0.098 ms** | **0.087 ms** |
| **Monocypher.Argon2id** | **64 MiB**   | **6**          |   **288.92 ms** | **0.216 ms** | **0.202 ms** |
| **Monocypher.Argon2id** | **128 MiB**  | **1**          |   **101.89 ms** | **0.085 ms** | **0.075 ms** |
| **Monocypher.Argon2id** | **128 MiB**  | **3**          |   **297.82 ms** | **0.165 ms** | **0.129 ms** |
| **Monocypher.Argon2id** | **128 MiB**  | **6**          |   **593.61 ms** | **1.390 ms** | **1.161 ms** |
| **Monocypher.Argon2id** | **256 MiB**  | **1**          |   **208.70 ms** | **0.748 ms** | **0.663 ms** |
| **Monocypher.Argon2id** | **256 MiB**  | **3**          |   **609.95 ms** | **0.526 ms** | **0.411 ms** |
| **Monocypher.Argon2id** | **256 MiB**  | **6**          | **1,210.27 ms** | **0.986 ms** | **0.874 ms** |
| **Monocypher.Argon2id** | **512 MiB**  | **1**          |   **424.69 ms** | **0.315 ms** | **0.263 ms** |
| **Monocypher.Argon2id** | **512 MiB**  | **3**          | **1,249.49 ms** | **3.433 ms** | **2.866 ms** |
| **Monocypher.Argon2id** | **512 MiB**  | **6**          | **2,473.55 ms** | **0.947 ms** | **0.886 ms** |
| **Monocypher.Argon2id** | **768 MiB**  | **1**          |   **643.46 ms** | **0.679 ms** | **0.602 ms** |
| **Monocypher.Argon2id** | **768 MiB**  | **3**          | **1,894.87 ms** | **2.414 ms** | **2.140 ms** |
| **Monocypher.Argon2id** | **768 MiB**  | **6**          | **3,742.12 ms** | **2.535 ms** | **2.117 ms** |
| **Monocypher.Argon2id** | **1 GiB** | **1**          |   **863.77 ms** | **0.637 ms** | **0.532 ms** |
| **Monocypher.Argon2id** | **1 GiB** | **3**          | **2,527.08 ms** | **0.526 ms** | **0.439 ms** |
| **Monocypher.Argon2id** | **1 GiB** | **6**          | **5,036.87 ms** | **3.029 ms** | **2.530 ms** |

### Konscious
| Method           | MemorySize | Iterations | Mean        | Error     | StdDev   |
|----------------- |----------- |----------- |------------:|----------:|---------:|
| **Konscious.Argon2id** | **32 MiB**   | **1**          |    **41.16 ms** |  **0.195 ms** | **0.182 ms** |
| **Konscious.Argon2id** | **32 MiB**   | **3**          |   **119.71 ms** |  **0.158 ms** | **0.132 ms** |
| **Konscious.Argon2id** | **32 MiB**   | **6**          |   **237.38 ms** |  **0.483 ms** | **0.428 ms** |
| **Konscious.Argon2id** | **64 MiB**   | **1**          |    **85.44 ms** |  **0.716 ms** | **0.635 ms** |
| **Konscious.Argon2id** | **64 MiB**   | **3**          |   **238.64 ms** |  **0.465 ms** | **0.435 ms** |
| **Konscious.Argon2id** | **64 MiB**   | **6**          |   **474.61 ms** |  **0.761 ms** | **0.674 ms** |
| **Konscious.Argon2id** | **128 MiB**  | **1**          |   **190.08 ms** |  **1.365 ms** | **1.210 ms** |
| **Konscious.Argon2id** | **128 MiB**  | **3**          |   **482.57 ms** |  **0.806 ms** | **0.754 ms** |
| **Konscious.Argon2id** | **128 MiB**  | **6**          |   **958.35 ms** |  **1.363 ms** | **1.275 ms** |
| **Konscious.Argon2id** | **256 MiB**  | **1**          |   **331.96 ms** |  **1.679 ms** | **1.488 ms** |
| **Konscious.Argon2id** | **256 MiB**  | **3**          |   **974.68 ms** |  **1.687 ms** | **1.495 ms** |
| **Konscious.Argon2id** | **256 MiB**  | **6**          | **1,935.99 ms** |  **2.912 ms** | **2.724 ms** |
| **Konscious.Argon2id** | **512 MiB**  | **1**          |   **669.21 ms** |  **2.102 ms** | **1.864 ms** |
| **Konscious.Argon2id** | **512 MiB**  | **3**          | **1,972.26 ms** |  **2.537 ms** | **2.373 ms** |
| **Konscious.Argon2id** | **512 MiB**  | **6**          | **3,917.41 ms** |  **2.698 ms** | **2.392 ms** |
| **Konscious.Argon2id** | **768 MiB**  | **1**          | **1,008.55 ms** |  **2.782 ms** | **2.172 ms** |
| **Konscious.Argon2id** | **768 MiB**  | **3**          | **2,985.42 ms** |  **2.953 ms** | **2.617 ms** |
| **Konscious.Argon2id** | **768 MiB**  | **6**          | **5,937.51 ms** | **10.120 ms** | **9.466 ms** |
| **Konscious.Argon2id** | **1 GiB** | **1**          | **1,356.23 ms** |  **6.741 ms** | **6.306 ms** |
| **Konscious.Argon2id** | **1 GiB** | **3**          | **4,001.81 ms** |  **5.927 ms** | **5.254 ms** |
| **Konscious.Argon2id** | **1 GiB** | **6**          | **7,951.15 ms** |  **6.485 ms** | **5.749 ms** |

### Isopoh
| Method        | MemorySize | Iterations | Mean         | Error     | StdDev    |
|-------------- |----------- |----------- |-------------:|----------:|----------:|
| **Isopoh.Argon2id** | **32 MiB**   | **1**          |     **67.17 ms** |  **1.307 ms** |  **1.832 ms** |
| **Isopoh.Argon2id** | **32 MiB**   | **3**          |    **163.87 ms** |  **2.015 ms** |  **1.884 ms** |
| **Isopoh.Argon2id** | **32 MiB**   | **6**          |    **323.91 ms** |  **4.754 ms** |  **4.447 ms** |
| **Isopoh.Argon2id** | **64 MiB**   | **1**          |    **122.73 ms** |  **2.081 ms** |  **1.947 ms** |
| **Isopoh.Argon2id** | **64 MiB**   | **3**          |    **340.69 ms** |  **6.551 ms** |  **8.045 ms** |
| **Isopoh.Argon2id** | **64 MiB**   | **6**          |    **635.39 ms** |  **1.355 ms** |  **1.132 ms** |
| **Isopoh.Argon2id** | **128 MiB**  | **1**          |    **241.11 ms** |  **2.874 ms** |  **3.195 ms** |
| **Isopoh.Argon2id** | **128 MiB**  | **3**          |    **646.84 ms** |  **1.249 ms** |  **0.975 ms** |
| **Isopoh.Argon2id** | **128 MiB**  | **6**          |  **1,289.58 ms** |  **2.407 ms** |  **2.010 ms** |
| **Isopoh.Argon2id** | **256 MiB**  | **1**          |    **450.25 ms** |  **4.724 ms** |  **3.945 ms** |
| **Isopoh.Argon2id** | **256 MiB**  | **3**          |  **1,319.16 ms** |  **6.722 ms** |  **6.288 ms** |
| **Isopoh.Argon2id** | **256 MiB**  | **6**          |  **2,633.85 ms** |  **4.751 ms** |  **4.444 ms** |
| **Isopoh.Argon2id** | **512 MiB**  | **1**          |    **889.61 ms** |  **3.468 ms** |  **3.244 ms** |
| **Isopoh.Argon2id** | **512 MiB**  | **3**          |  **2,662.51 ms** |  **4.301 ms** |  **4.023 ms** |
| **Isopoh.Argon2id** | **512 MiB**  | **6**          |  **5,314.12 ms** | **10.544 ms** |  **9.347 ms** |
| **Isopoh.Argon2id** | **768 MiB**  | **1**          |  **1,327.93 ms** |  **2.333 ms** |  **2.068 ms** |
| **Isopoh.Argon2id** | **768 MiB**  | **3**          |  **3,995.75 ms** | **10.862 ms** | **10.160 ms** |
| **Isopoh.Argon2id** | **768 MiB**  | **6**          |  **8,016.83 ms** |  **9.086 ms** |  **7.588 ms** |
| **Isopoh.Argon2id** | **1 GiB** | **1**          |  **1,800.93 ms** | **18.936 ms** | **14.784 ms** |
| **Isopoh.Argon2id** | **1 GiB** | **3**          |  **5,374.73 ms** |  **8.866 ms** |  **8.294 ms** |
| **Isopoh.Argon2id** | **1 GiB** | **6**          | **10,825.22 ms** | **59.007 ms** | **55.195 ms** |

## Laptop Results
### Setup
```
BenchmarkDotNet v0.13.12, macOS Sonoma 14.4 (23E214) [Darwin 23.4.0]

Apple M1, 1 CPU, 8 logical and 8 physical cores

.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.4 (8.0.424.16909), Arm64 RyuJIT AdvSIMD
```

### Libsodium
| Method             | MemorySize | Iterations | Mean        | Error     | StdDev    |
|------------------- |----------- |----------- |------------:|----------:|----------:|
| **Libsodium.Argon2id** | **32 MiB**   | **1**          |    **14.94 ms** |  **0.023 ms** |  **0.021 ms** |
| **Libsodium.Argon2id** | **32 MiB**   | **3**          |    **42.04 ms** |  **0.025 ms** |  **0.021 ms** |
| **Libsodium.Argon2id** | **32 MiB**   | **6**          |    **82.47 ms** |  **0.057 ms** |  **0.051 ms** |
| **Libsodium.Argon2id** | **64 MiB**   | **1**          |    **31.28 ms** |  **0.092 ms** |  **0.086 ms** |
| **Libsodium.Argon2id** | **64 MiB**   | **3**          |    **89.27 ms** |  **0.349 ms** |  **0.326 ms** |
| **Libsodium.Argon2id** | **64 MiB**   | **6**          |   **177.19 ms** |  **0.876 ms** |  **0.820 ms** |
| **Libsodium.Argon2id** | **128 MiB**  | **1**          |    **65.76 ms** |  **0.350 ms** |  **0.328 ms** |
| **Libsodium.Argon2id** | **128 MiB**  | **3**          |   **188.29 ms** |  **0.848 ms** |  **0.662 ms** |
| **Libsodium.Argon2id** | **128 MiB**  | **6**          |   **373.34 ms** |  **1.742 ms** |  **1.455 ms** |
| **Libsodium.Argon2id** | **256 MiB**  | **1**          |   **136.62 ms** |  **1.205 ms** |  **1.127 ms** |
| **Libsodium.Argon2id** | **256 MiB**  | **3**          |   **392.14 ms** |  **0.419 ms** |  **0.327 ms** |
| **Libsodium.Argon2id** | **256 MiB**  | **6**          |   **777.58 ms** |  **2.207 ms** |  **1.723 ms** |
| **Libsodium.Argon2id** | **512 MiB**  | **1**          |   **279.59 ms** |  **2.914 ms** |  **2.725 ms** |
| **Libsodium.Argon2id** | **512 MiB**  | **3**          |   **815.10 ms** |  **8.231 ms** |  **7.699 ms** |
| **Libsodium.Argon2id** | **512 MiB**  | **6**          | **1,615.96 ms** | **11.496 ms** | **10.753 ms** |
| **Libsodium.Argon2id** | **768 MiB**  | **1**          |   **426.70 ms** |  **3.671 ms** |  **3.434 ms** |
| **Libsodium.Argon2id** | **768 MiB**  | **3**          | **1,242.09 ms** |  **5.894 ms** |  **5.514 ms** |
| **Libsodium.Argon2id** | **768 MiB**  | **6**          | **2,464.89 ms** | **16.922 ms** | **15.829 ms** |
| **Libsodium.Argon2id** | **1 GiB** | **1**          |   **577.60 ms** |  **5.148 ms** |  **4.815 ms** |
| **Libsodium.Argon2id** | **1 GiB** | **3**          | **1,663.32 ms** |  **9.274 ms** |  **8.675 ms** |
| **Libsodium.Argon2id** | **1 GiB** | **6**          | **3,300.27 ms** | **21.562 ms** | **20.170 ms** |

### Monocypher
| Method            | MemorySize | Iterations | Mean        | Error     | StdDev    |
|------------------ |----------- |----------- |------------:|----------:|----------:|
| **Monocypher.Argon2id** | **32 MiB**   | **1**          |    **125.8 ms** |   **1.02 ms** |   **0.96 ms** |
| **Monocypher.Argon2id** | **32 MiB**   | **3**          |    **359.7 ms** |   **2.21 ms** |   **2.06 ms** |
| **Monocypher.Argon2id** | **32 MiB**   | **6**          |    **719.3 ms** |   **0.81 ms** |   **0.63 ms** |
| **Monocypher.Argon2id** | **64 MiB**   | **1**          |    **249.7 ms** |   **1.36 ms** |   **1.27 ms** |
| **Monocypher.Argon2id** | **64 MiB**   | **3**          |    **727.3 ms** |   **2.69 ms** |   **2.24 ms** |
| **Monocypher.Argon2id** | **64 MiB**   | **6**          |  **1,445.4 ms** |  **10.90 ms** |   **9.10 ms** |
| **Monocypher.Argon2id** | **128 MiB**  | **1**          |    **502.0 ms** |   **4.59 ms** |   **4.29 ms** |
| **Monocypher.Argon2id** | **128 MiB**  | **3**          |  **1,460.3 ms** |   **3.18 ms** |   **2.66 ms** |
| **Monocypher.Argon2id** | **128 MiB**  | **6**          |  **2,902.7 ms** |   **2.37 ms** |   **1.85 ms** |
| **Monocypher.Argon2id** | **256 MiB**  | **1**          |  **1,038.3 ms** |  **10.93 ms** |  **10.22 ms** |
| **Monocypher.Argon2id** | **256 MiB**  | **3**          |  **3,004.2 ms** |  **14.24 ms** |  **13.32 ms** |
| **Monocypher.Argon2id** | **256 MiB**  | **6**          |  **5,934.1 ms** |   **8.71 ms** |   **6.80 ms** |
| **Monocypher.Argon2id** | **512 MiB**  | **1**          |  **2,074.0 ms** |   **3.77 ms** |   **3.35 ms** |
| **Monocypher.Argon2id** | **512 MiB**  | **3**          |  **5,999.3 ms** |  **29.20 ms** |  **25.89 ms** |
| **Monocypher.Argon2id** | **512 MiB**  | **6**          | **11,860.7 ms** |  **99.90 ms** |  **93.44 ms** |
| **Monocypher.Argon2id** | **768 MiB**  | **1**          |  **3,121.3 ms** |  **19.02 ms** |  **17.79 ms** |
| **Monocypher.Argon2id** | **768 MiB**  | **3**          |  **9,061.2 ms** |   **6.59 ms** |   **6.16 ms** |
| **Monocypher.Argon2id** | **768 MiB**  | **6**          | **18,056.4 ms** | **142.48 ms** | **133.27 ms** |
| **Monocypher.Argon2id** | **1 GiB** | **1**          |  **4,152.4 ms** |   **6.94 ms** |   **6.49 ms** |
| **Monocypher.Argon2id** | **1 GiB** | **3**          | **12,082.7 ms** | **145.81 ms** | **136.39 ms** |
| **Monocypher.Argon2id** | **1 GiB** | **6**          | **23,784.5 ms** | **163.53 ms** | **152.97 ms** |

### Konscious
| Method           | MemorySize | Iterations | Mean        | Error     | StdDev    |
|----------------- |----------- |----------- |------------:|----------:|----------:|
| **Konscious.Argon2id** | **32 MiB**   | **1**          |    **38.49 ms** |  **0.109 ms** |  **0.097 ms** |
| **Konscious.Argon2id** | **32 MiB**   | **3**          |   **110.77 ms** |  **0.437 ms** |  **0.408 ms** |
| **Konscious.Argon2id** | **32 MiB**   | **6**          |   **219.16 ms** |  **0.624 ms** |  **0.553 ms** |
| **Konscious.Argon2id** | **64 MiB**   | **1**          |    **78.01 ms** |  **0.324 ms** |  **0.303 ms** |
| **Konscious.Argon2id** | **64 MiB**   | **3**          |   **225.99 ms** |  **1.176 ms** |  **1.100 ms** |
| **Konscious.Argon2id** | **64 MiB**   | **6**          |   **446.08 ms** |  **3.118 ms** |  **2.917 ms** |
| **Konscious.Argon2id** | **128 MiB**  | **1**          |   **158.09 ms** |  **0.939 ms** |  **0.878 ms** |
| **Konscious.Argon2id** | **128 MiB**  | **3**          |   **460.05 ms** |  **3.360 ms** |  **3.143 ms** |
| **Konscious.Argon2id** | **128 MiB**  | **6**          |   **910.16 ms** |  **4.817 ms** |  **4.506 ms** |
| **Konscious.Argon2id** | **256 MiB**  | **1**          |   **319.78 ms** |  **1.854 ms** |  **1.735 ms** |
| **Konscious.Argon2id** | **256 MiB**  | **3**          |   **922.34 ms** |  **1.454 ms** |  **1.360 ms** |
| **Konscious.Argon2id** | **256 MiB**  | **6**          | **1,825.25 ms** |  **1.388 ms** |  **1.230 ms** |
| **Konscious.Argon2id** | **512 MiB**  | **1**          |   **649.95 ms** |  **1.900 ms** |  **1.684 ms** |
| **Konscious.Argon2id** | **512 MiB**  | **3**          | **1,876.59 ms** |  **2.669 ms** |  **2.497 ms** |
| **Konscious.Argon2id** | **512 MiB**  | **6**          | **3,726.51 ms** | **28.166 ms** | **26.347 ms** |
| **Konscious.Argon2id** | **768 MiB**  | **1**          |   **990.51 ms** | **10.592 ms** |  **9.907 ms** |
| **Konscious.Argon2id** | **768 MiB**  | **3**          | **2,847.02 ms** | **24.236 ms** | **22.671 ms** |
| **Konscious.Argon2id** | **768 MiB**  | **6**          | **5,661.55 ms** | **40.313 ms** | **37.709 ms** |
| **Konscious.Argon2id** | **1 GiB** | **1**          | **1,325.72 ms** | **13.766 ms** | **12.877 ms** |
| **Konscious.Argon2id** | **1 GiB** | **3**          | **3,821.70 ms** | **35.343 ms** | **33.060 ms** |
| **Konscious.Argon2id** | **1 GiB** | **6**          | **7,486.17 ms** | **32.776 ms** | **25.590 ms** |

### Isopoh
| Method        | MemorySize | Iterations | Mean        | Error     | StdDev    | Median      |
|-------------- |----------- |----------- |------------:|----------:|----------:|------------:|
| **Isopoh.Argon2id** | **32 MiB**   | **1**          |    **41.46 ms** |  **0.674 ms** |  **1.144 ms** |    **41.02 ms** |
| **Isopoh.Argon2id** | **32 MiB**   | **3**          |   **108.74 ms** |  **0.591 ms** |  **0.553 ms** |   **108.77 ms** |
| **Isopoh.Argon2id** | **32 MiB**   | **6**          |   **213.29 ms** |  **2.806 ms** |  **2.343 ms** |   **212.50 ms** |
| **Isopoh.Argon2id** | **64 MiB**   | **1**          |    **85.51 ms** |  **1.681 ms** |  **2.900 ms** |    **86.79 ms** |
| **Isopoh.Argon2id** | **64 MiB**   | **3**          |   **222.40 ms** |  **0.646 ms** |  **0.604 ms** |   **222.36 ms** |
| **Isopoh.Argon2id** | **64 MiB**   | **6**          |   **438.00 ms** |  **0.773 ms** |  **0.723 ms** |   **437.83 ms** |
| **Isopoh.Argon2id** | **128 MiB**  | **1**          |   **167.42 ms** |  **3.345 ms** |  **6.116 ms** |   **169.90 ms** |
| **Isopoh.Argon2id** | **128 MiB**  | **3**          |   **459.06 ms** |  **2.496 ms** |  **2.335 ms** |   **458.12 ms** |
| **Isopoh.Argon2id** | **128 MiB**  | **6**          |   **920.57 ms** |  **5.327 ms** |  **4.983 ms** |   **920.04 ms** |
| **Isopoh.Argon2id** | **256 MiB**  | **1**          |   **321.55 ms** |  **3.257 ms** |  **2.720 ms** |   **321.37 ms** |
| **Isopoh.Argon2id** | **256 MiB**  | **3**          |   **953.90 ms** |  **1.791 ms** |  **1.587 ms** |   **953.80 ms** |
| **Isopoh.Argon2id** | **256 MiB**  | **6**          | **1,904.65 ms** | **13.461 ms** | **12.592 ms** | **1,900.45 ms** |
| **Isopoh.Argon2id** | **512 MiB**  | **1**          |   **717.74 ms** | **14.202 ms** | **26.675 ms** |   **728.49 ms** |
| **Isopoh.Argon2id** | **512 MiB**  | **3**          | **1,990.66 ms** | **37.234 ms** | **34.829 ms** | **1,986.92 ms** |
| **Isopoh.Argon2id** | **512 MiB**  | **6**          | **3,966.58 ms** | **48.672 ms** | **45.528 ms** | **3,964.78 ms** |
| **Isopoh.Argon2id** | **768 MiB**  | **1**          | **1,072.28 ms** | **20.810 ms** | **31.780 ms** | **1,085.03 ms** |
| **Isopoh.Argon2id** | **768 MiB**  | **3**          | **3,057.95 ms** | **33.916 ms** | **31.725 ms** | **3,070.98 ms** |
| **Isopoh.Argon2id** | **768 MiB**  | **6**          | **6,022.12 ms** | **28.323 ms** | **23.651 ms** | **6,021.83 ms** |
| **Isopoh.Argon2id** | **1 GiB** | **1**          | **1,461.72 ms** | **28.951 ms** | **37.645 ms** | **1,472.07 ms** |
| **Isopoh.Argon2id** | **1 GiB** | **3**          | **4,128.55 ms** |  **9.926 ms** |  **8.288 ms** | **4,127.23 ms** |
| **Isopoh.Argon2id** | **1 GiB** | **6**          | **8,188.90 ms** | **80.073 ms** | **74.901 ms** | **8,180.37 ms** |
