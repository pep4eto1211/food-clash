using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace FoodClash.Api.Helpers
{
    public static class PasswordsHelper
    {
        public static string HashPassword(string password, string saltBase64String)
        {
            byte[] salt = Convert.FromBase64String(saltBase64String);

            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
        }

        public static string GetRandomBase64StringSalt()
        {
            byte[] salt = new byte[128 / 8];

            var rng = RandomNumberGenerator.Create();
            rng.GetNonZeroBytes(salt);

            return Convert.ToBase64String(salt);
        }
    }
}
