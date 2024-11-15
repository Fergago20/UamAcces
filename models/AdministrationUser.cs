using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UamAcces.models
{
    internal class AdministrationUser
    {
        private const string Registro = "Registro.dat";
        List<User> users = new List<User>();

        private void SaveUsers()
        {
            File.Delete(Registro);
            FileStream WriterFile = new FileStream(Registro, FileMode.Create, FileAccess.Write);
            BinaryWriter Writer = new BinaryWriter(WriterFile);

            foreach (var user in users)
            {
                Writer.Write(user.CIF);
                Writer.Write(user.Password);
                Writer.Write(user.Name);
                Writer.Write(user.LastName);
                Writer.Write(user.Faculty);
                Writer.Write(user.Role);
                Writer.Write(user.Reason);
            }
            Writer.Close();
        }

        public void DeleteUser(int cif)
        {
            foreach (var user in users)
            {
                if (cif == user.CIF)
                {
                    users.Remove(user);
                }
            }
            SaveUsers();
        }

        public bool Verification(int cif, int password)
        {
            if (File.Exists(Registro))
            {
                foreach (var user in users)
                {
                    
                    if (user.CIF == cif && user.Password == password)
                    {
                        return true; 
                    }
                }
                return false; 
            }
            return false;
        }
        public void AddUser(User user, int cif, int password)
        {
            if (Verification(cif, password))
            {
                users.Add(user);
                SaveUsers();
            }
        }

        public User Data(int cif)
        {
            foreach (var user in users)
            {
                if (cif == user.CIF)
                {
                    return user;
                }
            }
            return null;
        }

        public void Update(User user, int cif)
        {
            int index = users.FindIndex(user1 => user1.CIF == cif);
            if (index != -1)
            {
                users[index] = user;
            }
            SaveUsers();
        }

        public void ReadFile()
        {
            if (File.Exists(Registro))
            {


                List<User> users2 = new List<User>();
                FileStream File = new FileStream(Registro, FileMode.Open, FileAccess.Read); ;
                BinaryReader Reader = new BinaryReader(File);

                while (File.Position != File.Length)
                {
                    User user = new User();
                    user.CIF = Reader.ReadInt32();
                    user.Password = Reader.ReadInt32();
                    user.Name = Reader.ReadString();
                    user.LastName = Reader.ReadString();
                    user.Faculty = Reader.ReadString();
                    user.Role = Reader.ReadString();
                    user.Reason = Reader.ReadString();
                    users2.Add(user);
                }
                Reader.Close();
                users.Clear();
                users = users2;
            }
        }
        public User Find(int cif, int password)
        {
            foreach (User user in users)
            {
                if (user.Password == password && user.CIF == cif)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
