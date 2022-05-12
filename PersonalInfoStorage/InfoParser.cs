using System.Security.Cryptography;
using System.Text;

namespace PersonalInfoStorage
{
    internal class InfoParser
    {
        public static string[] Parse(string text)
        {
            string[] words = text.Split('\n'); 
            return words;
        }
    }
}
