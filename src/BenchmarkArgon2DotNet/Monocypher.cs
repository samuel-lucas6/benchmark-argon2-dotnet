using static Monocypher.Monocypher;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkArgon2DotNet;

public class Monocypher
{
    private readonly byte[] _outputKeyingMaterial = new byte[Config.OutputSize];
    private readonly byte[] _password = Encoding.UTF8.GetBytes(Config.Password);
    private readonly byte[] _salt = new byte[Config.SaltSize];
    public static int[] _memorySizes => Config.MemorySizes;
    public static int[] _iterations => Config.Iterations;
    private byte[] _workArea;
    private crypto_argon2_config _config;
    private crypto_argon2_inputs _inputs;
    private crypto_argon2_extras _extras;

    [ParamsSource(nameof(_memorySizes))]
    public int MemorySize;

    [ParamsSource(nameof(_iterations))]
    public int Iterations;

    [GlobalSetup]
    public unsafe void Setup()
    {
        RandomNumberGenerator.Fill(_salt);
        _workArea = new byte[MemorySize];
        fixed (byte* p = _password, s = _salt) {
            _config = new crypto_argon2_config
            {
                algorithm = Config.Algorithm,
                nb_blocks = (uint)(MemorySize / Constants.BlockSize),
                nb_passes = (uint)Iterations,
                nb_lanes = Config.Parallelism
            };
            _inputs = new crypto_argon2_inputs
            {
                pass = new IntPtr(p),
                salt = new IntPtr(s),
                pass_size = (uint)_password.Length,
                salt_size = (uint)_salt.Length
            };
            _extras = new crypto_argon2_extras
            {
                key = IntPtr.Zero,
                ad = IntPtr.Zero,
                key_size = 0,
                ad_size = 0
            };
        }
    }

    [Benchmark(Description = "Monocypher.Argon2")]
    public void Argon2() => crypto_argon2(_outputKeyingMaterial, _workArea, _config, _inputs, _extras);
}
