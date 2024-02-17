namespace BenchmarkArgon2DotNet;

// +-------------+-----------+------------+-----------+----------+
// |             | Libsodium | Monocypher | Konscious | Isopoh   |
// +-------------+-----------+------------+-----------+----------+
// | Algorithm   | N/A       | = 0-2      | = 0-2     | = 0-2    |
// | OutputSize  | >= 16     | >= 1       | <= 1024   | >= 4     |
// | SaltSize    | = 16      | >= 8       | >= 0      | >= 8     |
// | MemorySize  | >= 8 KiB  | >= 8 KiB   | >= 4 KiB  | >= 1 KiB |
// | Iterations  | >= 1      | >= 1       | >= 1      | >= 1     |
// | Parallelism | N/A       | = 1        | >= 1      | >= 1     |
// +-------------+-----------+------------+-----------+----------+
// * For Algorithm, Argon2d = 0, Argon2i = 1, Argon2id = 2
// ** MemorySize MUST be specified in bytes in this file
// *** Iterations SHOULD be at least 3 with Argon2i to avoid attacks
// **** Monocypher does not support threads even though the parallelism can be adjusted
public static class Config
{
    public const string Password = "correct horse battery staple";

    public const int Algorithm = 2;

    public const int OutputSize = 32;

    public const int SaltSize = 16;

    // 64 MiB, 128 MiB, 256 MiB, 512 MiB, 768 MiB, 1 GiB (in bytes) = [67108864, 134217728, 268435456, 536870912, 805306368, 1073741824];
    public static readonly int[] MemorySizes = [67108864, 134217728, 268435456];

    // [1, 2, 3, 4, 5, 6];
    public static readonly int[] Iterations = [1, 3, 6];

    public const int Parallelism = 1;
}
