using System;
using System.Security.Cryptography;

namespace AgriConnect
{
    internal static class PasswordSecurity
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int IterationCount = 100000;
        private const string FormatName = "PBKDF2-SHA256";

        internal static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) ||
                password.Length < 8)
            {
                return false;
            }

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                    return false;

                if (char.IsLetter(character))
                    hasLetter = true;

                if (char.IsDigit(character))
                    hasDigit = true;
            }

            return hasLetter && hasDigit;
        }

        internal static string HashPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            byte[] salt = new byte[SaltSize];

            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(salt);
            }

            using (Rfc2898DeriveBytes deriveBytes =
                new Rfc2898DeriveBytes(
                    password,
                    salt,
                    IterationCount,
                    HashAlgorithmName.SHA256))
            {
                byte[] hash = deriveBytes.GetBytes(HashSize);

                return FormatName + "$" +
                    IterationCount + "$" +
                    Convert.ToBase64String(salt) + "$" +
                    Convert.ToBase64String(hash);
            }
        }

        internal static bool VerifyPassword(
            string password,
            string storedPassword)
        {
            if (password == null || string.IsNullOrEmpty(storedPassword))
                return false;

            string[] parts = storedPassword.Split('$');

            if (parts.Length != 4 ||
                parts[0] != FormatName ||
                !int.TryParse(parts[1], out int iterations) ||
                iterations != IterationCount)
            {
                return false;
            }

            try
            {
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] storedHash = Convert.FromBase64String(parts[3]);

                if (salt.Length != SaltSize || storedHash.Length != HashSize)
                    return false;

                using (Rfc2898DeriveBytes deriveBytes =
                    new Rfc2898DeriveBytes(
                        password,
                        salt,
                        iterations,
                        HashAlgorithmName.SHA256))
                {
                    byte[] enteredHash = deriveBytes.GetBytes(HashSize);
                    int difference = 0;

                    for (int i = 0; i < storedHash.Length; i++)
                    {
                        difference |= storedHash[i] ^ enteredHash[i];
                    }

                    return difference == 0;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
