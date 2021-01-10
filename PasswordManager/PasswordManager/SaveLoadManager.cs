using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace PasswordManager
{
    public class SaveLoadManager
    {
        private const string cryptoKey = "kWW6y7xMrrn15bFZe62SYUADy2hbc7wj8ESgvpE0F1d=";
        private const string cryptoKey2 = "5U32kATBvw2tJ25PcxzdI9v1SUjuGqoZLbGofqOlr2I=";
        private const string cryptoKey3 = "I68DeSXXx4R300cr40hSp608eOrjlyFh49If2M5AZi9=";
        private const int keySize = 256;
        private const int ivSize = 16;

        private const string folder = "Mika";
        private const string userFile = "users.dat";
        private const string passwordFile = "passwords.dat";
        private const string groupFile = "group.dat";

        public static void WriteObjectToStream(Stream stream, Object data)
        {
            if (data == null)
            {
                return;
            }

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static object ReadObjectFromStream(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            object obj = formatter.Deserialize(stream);
            stream.Close();
            return obj;
        }

        #region Encryption/Decryption
        public static CryptoStream CreateEncryptionStrem(byte[] key, Stream stream)
        {
            byte[] iv = new byte[ivSize];

            using (var rng = new RNGCryptoServiceProvider())
            {
                // Using a cryptographic random number generator
                rng.GetNonZeroBytes(iv);
            }

            // Write IV to the start of the stream
            stream.Write(iv, 0, iv.Length);

            Rijndael rijndael = new RijndaelManaged();
            rijndael.KeySize = keySize;

            CryptoStream encryptor = new CryptoStream(stream, rijndael.CreateEncryptor(key, iv), CryptoStreamMode.Write);
            return encryptor;
        }

        public static CryptoStream CreateDecryptionStream(byte[] key, Stream inputStream)
        {
            byte[] iv = new byte[ivSize];

            if (inputStream.Read(iv, 0, iv.Length) != iv.Length)
            {
                throw new ApplicationException("Failed to read IV from stream.");
            }

            Rijndael rijndael = new RijndaelManaged();
            rijndael.KeySize = keySize;

            CryptoStream decryptor = new CryptoStream(inputStream, rijndael.CreateDecryptor(key, iv), CryptoStreamMode.Read);
            return decryptor;
        }
        #endregion

        #region Save and Load Passwords
        /// <summary>
        /// save the password information
        /// </summary>
        public static void Save(Data data,string currentUser)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "/" + folder + "/" +currentUser))
            {
                string folderName = Path.Combine(path, folder ,currentUser);
                Directory.CreateDirectory(folderName);
            }
            path += "/" + folder + "/" + currentUser + "/" + passwordFile;

            byte[] key = Convert.FromBase64String(cryptoKey);

            using (FileStream filestream = new FileStream(path, FileMode.Create))
            {
                using (CryptoStream cryptoStream = CreateEncryptionStrem(key, filestream))
                {
                    WriteObjectToStream(cryptoStream, data);
                }
            }
        }


        /// <summary>
        /// load the password information
        /// </summary>
        public static Data Load(string currentUser)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + folder + "/" + currentUser + "/" + passwordFile;

            if (File.Exists(path))
            {
                Data returnData;
                byte[] key = Convert.FromBase64String(cryptoKey);

                using (FileStream filestream = new FileStream(path, FileMode.Open))
                {
                    using (CryptoStream cryptoStream = CreateDecryptionStream(key, filestream))
                    {
                        returnData = (Data)ReadObjectFromStream(cryptoStream);
                    }
                }

                return returnData;
            }

            return null;
        }
        #endregion



        #region Save and Load Users
        /// <summary>
        /// save the user information
        /// </summary>
        public static void Save(UserData data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "/" + folder))
            {
                string folderName = Path.Combine(path, folder);
                Directory.CreateDirectory(folderName);
            }
            path += "/" + folder + "/" + userFile;

            byte[] key = Convert.FromBase64String(cryptoKey2);

            using (FileStream filestream = new FileStream(path, FileMode.Create))
            {
                using (CryptoStream cryptoStream = CreateEncryptionStrem(key, filestream))
                {
                    WriteObjectToStream(cryptoStream, data);
                }  
            }
            
        }

        /// <summary>
        /// load the user information
        /// </summary>
        public static UserData Load()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + folder + "/" + userFile;

            if (File.Exists(path))
            {
                UserData returnData;

                byte[] key = Convert.FromBase64String(cryptoKey2);

                using (FileStream filestream = new FileStream(path, FileMode.Open))
                {
                    using (CryptoStream cryptoStream = CreateDecryptionStream(key, filestream))
                    {
                        returnData = (UserData)ReadObjectFromStream(cryptoStream);
                    }
                }

                return returnData;
            }

            return null;
        }
        #endregion

        #region Save and Load groups
        /// <summary>
        /// save the group information
        /// </summary>
        public static void Save(GroupData data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "/" + folder))
            {
                string folderName = Path.Combine(path, folder);
                Directory.CreateDirectory(folderName);
            }
            path += "/" + folder + "/" + groupFile;

            byte[] key = Convert.FromBase64String(cryptoKey3);

            using (FileStream filestream = new FileStream(path, FileMode.Create))
            {
                using (CryptoStream cryptoStream = CreateEncryptionStrem(key, filestream))
                {
                    WriteObjectToStream(cryptoStream, data);
                }
            }

        }

        /// <summary>
        /// load the group information
        /// </summary>
        public static GroupData LoadGroups()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + folder + "/" + groupFile;

            if (File.Exists(path))
            {
                GroupData returnData;

                byte[] key = Convert.FromBase64String(cryptoKey3);

                using (FileStream filestream = new FileStream(path, FileMode.Open))
                {
                    using (CryptoStream cryptoStream = CreateDecryptionStream(key, filestream))
                    {
                        returnData = (GroupData)ReadObjectFromStream(cryptoStream);
                    }
                }

                return returnData;
            }

            return null;
        }
        #endregion
    }

    #region Passwords
    [Serializable]
    public class Data
    {
        public List<Password> passwords;

        public Data(List<Password> list)
        {
            passwords = list;
        }

        //public void Remove(int index)
        //{
        //    Password[] newArr = new Password[passwords.Length];

        //    for (int i = 0; i < passwords.Length; i++)
        //    {
        //        newArr[i] = passwords[i];
        //    }

        //    passwords[index] = null;

        //    for (int i = index; i < newArr.Length-1; i++)
        //    {
        //        newArr[i] = newArr[i + 1];
        //    }

        //    passwords = new Password[newArr.Length - 1];

        //    for (int i = 0; i < passwords.Length; i++)
        //    {
        //        passwords[i] = newArr[i];
        //    }
        //}
    }

    [Serializable]
    public class Password
    {
        public string name, email, username, password,groupName;
        // -1 is no group! > one of the groups depending on array index
        public int groupId;

        public Password(string n, string e, string u, string p,string groupName)
        {
            name = n;
            email = e;
            username = u;
            password = p;
            this.groupName = groupName;
        }
    }
    #endregion

    #region Users
    [Serializable]
    public class UserData
    {
        public string lastUser; 
        public List<UserClass> userList = new List<UserClass>();
        public UserData(List<UserClass> users, string lastU)
        {
            userList = users;
            lastUser = lastU;
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

    [Serializable]
    public class GroupData
    {
        public List<GroupClass> groupList;

        public GroupData(List<GroupClass> groupList)
        {
            this.groupList = groupList;
        }
    }

    [Serializable]
    public class GroupClass
    { 
        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }


        public GroupClass(string groupName)
        {
            this.groupName = groupName;
        }
    }
}
