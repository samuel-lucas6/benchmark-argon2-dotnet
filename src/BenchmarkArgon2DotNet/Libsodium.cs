using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using System.Text;
using Geralt;

namespace BenchmarkArgon2DotNet;

public class Libsodium
{
    private readonly byte[] _outputKeyingMaterial = new byte[Config.OutputSize];
    private readonly byte[] _password = Encoding.UTF8.GetBytes(Config.Password);
    private readonly byte[] _salt = new byte[Config.SaltSize];
    public static int[] _memorySizes => Config.MemorySizes;
    public static int[] _iterations => Config.Iterations;

    [ParamsSource(nameof(_memorySizes))]
    public int MemorySize;

    [ParamsSource(nameof(_iterations))]
    public int Iterations;

    [GlobalSetup]
    public void Setup() => RandomNumberGenerator.Fill(_salt);

    [Benchmark(Description = "Libsodium.Argon2id")]
    public void Argon2() => Argon2id.DeriveKey(_outputKeyingMaterial, _password, _salt, Iterations, MemorySize);
}
