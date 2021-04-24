using System;
using System.Text;
using System.Security.Cryptography;

namespace myBooks.API.Helpers
{
    public static class Security
    {
        public static string GenerateSalt()
        {
            var buffer = new byte[16];

            using (var provider = new RNGCryptoServiceProvider())
                provider.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public static string GenerateHash(string salt, string lozinka)
        {
            var src = Convert.FromBase64String(salt);
            var bytes = Encoding.Unicode.GetBytes(lozinka);
            var dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            var algorithm = HashAlgorithm.Create("SHA1");
            var inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray);
        }
    }
}
