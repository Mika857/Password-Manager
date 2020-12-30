using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PasswordManager
{
    public class SaveLoadManager
    {
        #region Save and Load Passwords
        public static void Save(Data data,string currentUser)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "/Mika/"+currentUser))
            {
                string folder = Path.Combine(path, "Mika",currentUser);
                Directory.CreateDirectory(folder);
            }
            path += "/Mika/" + currentUser + "/store.dat";

            FileStream filestream = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, data);
            filestream.Close();
        }

        public static Data Load(string currentUser)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Mika/" + currentUser + "/store.dat";

            if (File.Exists(path))
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Data data = (Data)formatter.Deserialize(fileStream);
                fileStream.Close();
                return data;
            }

            return null;
        }
        #endregion

        #region Save and Load Users
        public static void SaveUser(SaveUsers data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "/Mika"))
            {
                string folder = Path.Combine(path, "Mika");
                Directory.CreateDirectory(folder);
            }
            path += "/Mika/users.dat";

            FileStream filestream = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, data);
            filestream.Close();
        }

        public static SaveUsers LoadUsers()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Mika/users.dat";

            if (File.Exists(path))
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                SaveUsers data = (SaveUsers)formatter.Deserialize(fileStream);
                fileStream.Close();
                return data;
            }

            return null;
        }
        #endregion
    }

    #region Passwords
    [Serializable]
    public class Data
    {
        public Password[] passwords;

        public Data(Password[] list)
        {
            passwords = new Password[list.Length];
            for(int i = 0;i < list.Length;i++)
            {
                passwords[i] = list[i];
            }
        }

        public void Remove(int index)
        {
            Password[] newArr = new Password[passwords.Length];

            for (int i = 0; i < passwords.Length; i++)
            {
                newArr[i] = passwords[i];
            }

            passwords[index] = null;

            for (int i = index; i < newArr.Length-1; i++)
            {
                newArr[i] = newArr[i + 1];
            }

            passwords = new Password[newArr.Length - 1];

            for (int i = 0; i < passwords.Length; i++)
            {
                passwords[i] = newArr[i];
            }
        }
    }

    [Serializable]
    public class Password
    {
        public string name, email, username, password;

        public Password(string n, string e, string u, string p)
        {
            name = n;
            email = e;
            username = u;
            password = p;
        }
    }
    #endregion

    #region Users
    [Serializable]
    public class SaveUsers
    {
        public List<UserClass> userList = new List<UserClass>();
        public SaveUsers(List<UserClass> users)
        {
            userList = users;
        }
    }

    [Serializable]
    public class UserClass
    {
        public string username,password;

        public UserClass(string uname,string pass)
        {
            username = uname;
            password = pass;
        }
    }
    #endregion
}
