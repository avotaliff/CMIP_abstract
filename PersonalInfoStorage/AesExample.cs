using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PersonalInfoStorage
{
    public class AesExample
    {
        private string _encrypDataPath = ""; //закрытый ключ + личная инфа
        private byte[] _key; //пароль + соль + хеширование
        private byte[] _IV = new byte[16];
        KeyManager km;

        public AesExample(string password, string userName)
        {
            _encrypDataPath += userName + ".txt";
            km = new KeyManager(userName + ".txt");
            _key = km.GetKey(password);
        }

        public string CreateDecrypText()
        {
            string decrypText = "";
            //Расшифрование данных с использованием ключа, генерируемого на основе парольной фразы 
            using (var myAes = new AesCryptoServiceProvider())
            {
                //Режим шифрования
                myAes.Mode = CipherMode.CBC;
                myAes.BlockSize = 128;
                myAes.Padding = PaddingMode.PKCS7;

                //Формирование ключа              
                myAes.IV = _IV;
                myAes.Key = _key;

                //Расшифровка данных          
                ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);

                using (FileStream EncrypFile = File.OpenRead(_encrypDataPath))
                {
                    using (CryptoStream csDecryp = new CryptoStream(EncrypFile, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecryp = new StreamReader(csDecryp))
                        {
                            decrypText = srDecryp.ReadToEnd();
                        }
                    }
                }
            }
            return decrypText;
        }

        public void CreateEncrypFile(string text)
        {
            byte[] dataToEncryp = Encoding.UTF8.GetBytes(text);

            //Шифрование данных с использованием ключа, генерируемого на основе парольной фразы 
            using (var myAes = new AesCryptoServiceProvider())
            {
                //Режим шифрования
                myAes.Mode = CipherMode.CBC;
                myAes.BlockSize = 128;
                myAes.Padding = PaddingMode.PKCS7; 

                //Формирование ключа              
                myAes.IV = _IV;
                myAes.Key = _key;

                //Шифрование данных          
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                using (FileStream EncrypFile = File.Create(_encrypDataPath))
                {
                    using (CryptoStream csEncryp = new CryptoStream(EncrypFile, encryptor, CryptoStreamMode.Write))
                    {
                        csEncryp.Write(dataToEncryp, 0, dataToEncryp.Length);
                    }
                }
            }
        }
    }
}
