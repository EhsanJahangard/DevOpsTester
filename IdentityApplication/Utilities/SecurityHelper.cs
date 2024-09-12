using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;

namespace IdentityApplication.Utilities;

public static class SecurityHelper
{
    public static string EncryptData(this string plainText, IConfiguration configuration)
    {
        // Retrieve the secret key from the configuration
        string keyHex = configuration["EncryptSetting:SecretKey"];
        byte[] key = Convert.FromHexString(keyHex);

        // Create a new instance of the Aes class to perform the encryption
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.Mode = CipherMode.CBC;

            // Generate a new IV (Initialization Vector) for this encryption
            aes.GenerateIV();
            byte[] iv = aes.IV;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        // Write the plain text to the crypto stream
                        streamWriter.Write(plainText);
                    }

                    // Get the encrypted data from the memory stream
                    byte[] encrypted = memoryStream.ToArray();

                    // Convert the IV and encrypted data to hexadecimal strings and concatenate them with a colon separator
                    return $"{Convert.ToHexString(iv)}:{Convert.ToHexString(encrypted)}";
                }
            }
        }
    }

    public static string DecryptData(this string encryptedText, IConfiguration configuration)
    {
        string keyHex = configuration["EncryptSetting:SecretKey"];
        byte[] key = Convert.FromHexString(keyHex);
        string[] parts = encryptedText.Split(':');
        byte[] iv = Convert.FromHexString(parts[0]);
        byte[] buffer = Convert.FromHexString(parts[1]);

        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}
