using System;
using System.Security.Cryptography;
using System.Text;

namespace AgriConnect
{
    internal static class PasswordSecurity
    {
        internal static string GenerateSalt()
        {
            byte[] salt = new byte[16];

            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(salt);
            }

            return Convert.ToBase64String(salt);
        }

        internal static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(password + salt));

                return Convert.ToBase64String(hash);
            }
        }

        internal static bool VerifyPassword(
            string password,
            string salt,
            string passwordHash)
        {
            if (string.IsNullOrEmpty(salt) || string.IsNullOrEmpty(passwordHash))
                return false;

            string enteredHash = HashPassword(password, salt);

            return string.Equals(
                enteredHash,
                passwordHash,
                StringComparison.Ordinal);
        }
    }
}
