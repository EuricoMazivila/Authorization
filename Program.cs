using System;

namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_Key = "";
            string Public_Key = "";
            
            string token = RSAUtility.RSAEncrypt(API_Key, Public_Key);
            
            Console.WriteLine("");
            Console.WriteLine("Token");
            Console.WriteLine("");
            Console.WriteLine(token);

        }
    }

}
