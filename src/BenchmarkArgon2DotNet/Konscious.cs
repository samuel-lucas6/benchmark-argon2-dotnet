using Konscious.Security.Cryptography;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkArgon2DotNet;

public class Konscious
{
    private byte[] _outputKeyingMaterial = new byte[Config.OutputSize];
    private readonly byte[] _password = Encoding.UTF8.GetBytes(Config.Password);
    private readonly byte[] _salt = new byte[Config.SaltSize];
    public static int[] _memorySizes => Config.MemorySizes;
    public static int[] _iterations => Config.Iterations;
    private Argon2 _argon2;

    [ParamsSource(nameof(_memorySizes))]
    public int MemorySize;

    [ParamsSource(nameof(_iterations))]
    public int Iterations;

    [GlobalSetup]
    public void Setup()
    {
        RandomNumberGenerator.Fill(_salt);
        _argon2 = Config.Algorithm switch
        {
            0 => new Argon2d(_password),
            1 => new Argon2i(_password),
            2 => new Argon2id(_password),
            _ => throw new ArgumentOutOfRangeException()
        };
        _argon2.Salt = _salt;
        _argon2.MemorySize = MemorySize / Constants.BlockSize;
        _argon2.Iterations = Iterations;
        _argon2.DegreeOfParallelism = Config.Parallelism;
        _argon2.KnownSecret = Array.Empty<byte>();
        _argon2.AssociatedData = Array.Empty<byte>();
    }

    [Benchmark(Description = "Konscious.Argon2")]
    public void Argon2() => _outputKeyingMaterial = _argon2.GetBytes(_outputKeyingMaterial.Length);
}
