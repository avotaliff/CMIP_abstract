using System;
using System.IO;
using System.Collections.Generic;

namespace PersonalInfoStorage
{
    internal class UsersAccounts
    {
        public static List<string> CreateUserList()
        {
            List<string> usersList = new List<string>();
            string myPath = Directory.GetCurrentDirectory();
            Array.ForEach(Directory.GetFiles(myPath, "*.txt"), f => usersList.Add(Path.GetFileNameWithoutExtension(Path.GetFileName(f))));
            return usersList;
        }
    }
}
