using System;

namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_Key = "";
            string Public_Key = "";
            
            string m = RSAUtility.RSAEncrypt(API_Key, Public_Key);
            
            Console.WriteLine("");
            Console.WriteLine("Teste");
            Console.WriteLine("");
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }

}
