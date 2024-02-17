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
