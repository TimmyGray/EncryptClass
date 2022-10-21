using System.Text;

namespace EncryptClass
{
    public class OwnDecrypt
    {

        private long _key = 34543563123;

        public string DecryptString(string encryptpassword)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char word in encryptpassword)
            {
               char secretchar =  (char)(word ^ _key);
               sb.Append(secretchar);
            }
            return sb.ToString();
        }

    }
}