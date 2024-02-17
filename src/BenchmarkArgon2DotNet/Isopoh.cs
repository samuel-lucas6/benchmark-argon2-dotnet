using Isopoh.Cryptography.SecureArray;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using Isopoh.Cryptography.Argon2;
using System.Text;

namespace BenchmarkArgon2DotNet;

public class Isopoh
{
    private SecureArray<byte> _outputKeyingMaterial;
    private readonly byte[] _password = Encoding.UTF8.GetBytes(Config.Password);
    private readonly byte[] _salt = new byte[Config.SaltSize];
    public static int[] _memorySizes => Config.MemorySizes;
    public static int[] _iterations => Config.Iterations;
    private Argon2Config _config;

    [ParamsSource(nameof(_memorySizes))]
    public int MemorySize;

    [ParamsSource(nameof(_iterations))]
    public int Iterations;

    [GlobalSetup]
    public void Setup()
    {
        RandomNumberGenerator.Fill(_salt);
        _config = new Argon2Config
        {
            Type = (Argon2Type)Config.Algorithm,
            Version = Argon2Version.Nineteen,
            TimeCost = Iterations,
            MemoryCost = MemorySize / Constants.BlockSize,
            Lanes = Config.Parallelism,
            Threads = Config.Parallelism,
            Password = _password,
            Salt = _salt,
            Secret = null,
            AssociatedData = null,
            HashLength = Config.OutputSize
        };
    }

    [Benchmark(Description = "Isopoh.Argon2")]
    public void Argon2()
    {
        var argon2 = new Argon2(_config);
        _outputKeyingMaterial = argon2.Hash();
    }
}
