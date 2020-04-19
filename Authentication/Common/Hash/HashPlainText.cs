namespace University_Management_System_API.Authentication.Common
{
    using System;
    using Microsoft.AspNetCore.Cryptography.KeyDerivation;

    public static class HashPlainText
    {
        /// <summary>
        /// Hashing plain text plus salt with Sha512
        /// </summary>
        /// <param name="plainText">plain text</param>
        /// <param name="salt">salt</param> 
        /// <returns>hash token</returns>
        public static string GenerateHash(string plainText, byte[] salt)
        {
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: plainText,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 512 / 8));        

            return hashed;
        }
    }
}
