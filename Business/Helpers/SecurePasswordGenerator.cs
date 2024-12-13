using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business.Helpers;

public static class SecurePasswordGenerator
{
    public static (string, string) GeneratePassword(string password)
    {
        using var hmac = new HMACSHA256();
        var securedKey = Convert.ToBase64String(hmac.Key);
        var securedPassword = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));

        return (securedKey, securedPassword);
    }
}
