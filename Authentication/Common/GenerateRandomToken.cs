namespace University_Management_System_API.Authentication.Common
{
    using System;
    using System.Text;

    public static class GenerateRandomToken
    {
        /// <summary>
        /// Generates a random plain text and calls the function GenerateSalt and GenerateHash
        /// </summary>
        /// <returns>Random plain text</returns>
        public static string GenerateToken(byte[] salt)
        {
            string authToken = Guid.NewGuid().ToString();
            var plainTextBytes = Encoding.UTF8.GetBytes(authToken);

            string token = Convert.ToBase64String(plainTextBytes);

            return HashPlainText.GenerateHash(token, salt);
        }
    }
}
