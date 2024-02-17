using BenchmarkDotNet.Running;

namespace BenchmarkArgon2DotNet;

public class Program
{
    // +--------------+
    // | INSTRUCTIONS |
    // +--------------+
    // 1. Comment out the libraries you don't want to benchmark below.
    // 2. Edit the parameters in the Config.cs file.
    // 3. Build the project in Release mode.
    // 4. Close programs running in the background (and plug in your charger if using a laptop).
    // 5. Run the executable as admin/root (and leave your computer alone until the benchmark is done).
    // 6. View the results in the \bin\Release\net8.0\BenchmarkDotNet.Artifacts\results folder.
    public static void Main()
    {
        var libsodiumSummary = BenchmarkRunner.Run<Libsodium>();
        var monocypherSummary = BenchmarkRunner.Run<Monocypher>();
        var konsciousSummary = BenchmarkRunner.Run<Konscious>();
        var isopohSummary = BenchmarkRunner.Run<Isopoh>();
        Console.ReadLine();
    }
}
