using System.Security.Cryptography;
using System.Text;


namespace PersonalInfoStorage
{
    internal class KeyMD5
    {
        public static void ComputeHashKey(string password, out byte[] key, out string salt)
        {
            //Криптостойкое случайное число
            byte[] data = new byte[3];
            var csp = new RNGCryptoServiceProvider();
            csp.GetBytes(data);
            salt = Encoding.UTF8.GetString(data);

            MD5 md5 = MD5.Create();
            key = md5.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        }

        public static byte[] ComputeHashKey(string password, string salt)
        {
            MD5 md5 = MD5.Create();
            byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
            return key;
        }
    }
}
