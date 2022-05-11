using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PersonalInfoStorage
{
    public class AesExample
    {
        private byte[] _dataToEncryp;
        private string _encrypDataPath = @"EncrypInfo.txt";

        private byte[] _key;
        private byte[] _IV;

        private string _salt;

        public AesExample(string text, string password)
        {
            _dataToEncryp = Encoding.UTF8.GetBytes(text);

            //Криптостойкое случайное число
            byte[] data = new byte[3];
            var csp = new RNGCryptoServiceProvider();
            csp.GetBytes(data);
            _salt = Encoding.UTF8.GetString(data);

            MD5 md5 = MD5.Create();
            _key = md5.ComputeHash(Encoding.UTF8.GetBytes(password + _salt));
            _IV = new byte[_key.Length];
        }

        public void CreateEncrypFile()
        {
            //Шифрование данных с использованием ключа, генерируемого на основе парольной фразы 
            using (var myAes = new AesCryptoServiceProvider())
            {
                //Режим шифрования
                myAes.Mode = CipherMode.CBC;
                myAes.BlockSize = 128;
                myAes.Padding = PaddingMode.PKCS7;

                //Формирование ключа               
                myAes.Key = _key;
                myAes.IV = _IV;

                //Шифрование данных          
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                using (FileStream EncrypFile = File.Create(_encrypDataPath))
                {
                    using (CryptoStream csEncryp = new CryptoStream(EncrypFile, encryptor, CryptoStreamMode.Write))
                    {
                        csEncryp.Write(_dataToEncryp, 0, _dataToEncryp.Length);
                    }
                }
            }
        }
    }
}
