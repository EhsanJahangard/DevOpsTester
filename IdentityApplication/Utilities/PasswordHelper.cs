

using System.Security.Cryptography;
using System.Text;

namespace IdentityApplication.Utilities;

public static class PasswordHelper
{
    public static string Getsha256Hash(this string value)
    {
        var algoritm = new SHA256CryptoServiceProvider();
        var byteValue = Encoding.UTF8.GetBytes(value);
        var byteHash = algoritm.ComputeHash(byteValue);
        return Convert.ToBase64String(byteHash);
    }

    public static string EncodePasswordMd5(this string pass) //Encrypt using MD5   
    {
        Byte[] originalBytes;
        Byte[] encodedBytes;
        MD5 md5;
        //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)   
        md5 = new MD5CryptoServiceProvider();
        originalBytes = ASCIIEncoding.Default.GetBytes(pass);
        encodedBytes = md5.ComputeHash(originalBytes);
        //Convert encoded bytes back to a 'readable' string   
        return BitConverter.ToString(encodedBytes).Replace("-", "");
    }
}
