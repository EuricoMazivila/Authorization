using System;
using System.Security.Cryptography;
using System.Text;

namespace Authorization
{
    public class RSAUtility
    {
        public static string  RSAEncrypt(string apiKey, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSAParameters RSAKeyInfo = RSA.ExportParameters(false);
                    byte []encodedPublicKey= Encoding.Default.GetBytes(publicKey);
                    RSAKeyInfo.Modulus = encodedPublicKey;
                    RSA.ImportParameters(RSAKeyInfo);
                    byte[] encryp = RSA.Encrypt(Encoding.UTF8.GetBytes(apiKey), false);
                    return Convert.ToBase64String(encryp);
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }
    }
}