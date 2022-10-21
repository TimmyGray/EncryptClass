using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptClass
{
    public static class SysDecrypt
    {

        static readonly byte[] addentropy = { 2,4,5,7,5,1 };

        public static string Decrypt(string encryptpass)
        {

            try
            {
                
                byte[] bytes = ProtectedData.Unprotect(Convert.FromBase64String(encryptpass), addentropy, DataProtectionScope.LocalMachine);
               
                UnicodeEncoding unicode = new UnicodeEncoding();
                
                return unicode.GetString(bytes);
            }
            catch (CryptographicException e)
            {

                Console.WriteLine("Ошибка в дешифровке пароля");
                Console.WriteLine(e.ToString());
                return null;
            }
        }



    }
}
