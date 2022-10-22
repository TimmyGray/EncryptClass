using System.Text;

namespace EncryptClass
{
    public static class OwnDecrypt
    {

        public static string DecryptString(string encryptpassword, long key )
        {
            StringBuilder sb = new StringBuilder();
            foreach (char word in encryptpassword)
            {
               char secretchar =  (char)(word ^ key);
               sb.Append(secretchar);
            }
            return sb.ToString();
        }

    }
}