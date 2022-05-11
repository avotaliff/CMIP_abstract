using System.Text;
using System.IO;
namespace PersonalInfoStorage
{
    internal class KeyManager
    {
        private string _keyPath = @"Keys\key_";
        private string _saltPath = @"Keys\salt_";
        private byte[] _key;
        private string _salt;

        public KeyManager(string userNameFile)
        {
            _keyPath += userNameFile;
            _saltPath += userNameFile;
        }

        public void SaveKey()
        {
            File.WriteAllBytes(_keyPath, _key);
            File.WriteAllText(_saltPath, _salt);
        }

        public bool CheckKey(string pass)
        {
            byte[] key = File.ReadAllBytes(_keyPath);
            _salt = File.ReadAllText(_saltPath);
            _key = KeyMD5.ComputeHashKey(pass, _salt);
            if (Encoding.UTF8.GetString(_key) == Encoding.UTF8.GetString(key))
                return true;
            else
                return false;
        }

        public byte[] GetKey(string pass)
        {
            if (File.Exists(_keyPath))
            {
                _key = File.ReadAllBytes(_keyPath);
            }
            else
            {
                KeyMD5.ComputeHashKey(pass, out _key, out _salt);
                SaveKey();
            }      
            return _key;
        }
    }
}
