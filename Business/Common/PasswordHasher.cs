using System;
using System.Security.Cryptography;
using System.Text;

namespace LibrarySystem.Common
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 100000;

        public static string HashPassword(string plainPassword)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);

                using (Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(plainPassword, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] key = hash.GetBytes(KeySize);
                    return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(key)}";
                }
            }
        }

        public static bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            string[] parts = hashedPassword.Split('.');
            if (parts.Length != 3)
                return false;

            int iterations = int.Parse(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] key = Convert.FromBase64String(parts[2]);

            using (Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(plainPassword, salt, iterations, HashAlgorithmName.SHA256))
            {
                byte[] computedKey = hash.GetBytes(KeySize);
                for (int i = 0; i < computedKey.Length; i++)
                {
                    if (computedKey[i] != key[i])
                        return false;
                }
            }

            return true;
        }

        public static string CombinePasswordParts(string[] parts)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < parts.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(parts[i]))
                {
                    builder.Append(parts[i]);
                    if (i < parts.Length - 1)
                        builder.Append('.');
                }
            }
            return builder.ToString();
        }
    }
}