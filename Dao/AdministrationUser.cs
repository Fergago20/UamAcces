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
using UamAcces.Archivos;

namespace UamAcces.models
{
    internal class AdministrationUser
    {
        private const string Registro = "Registro.dat";
        List<User> users = new List<User>();
        AllFile files = new AllFile();

        public List<User> GetUsers() { return users; }

        public void SaveUsers()
        {
            files.SaveUsers(users);
        }

        public void DeleteUser(int cif)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (cif == users[i].CIF)
                {
                    users.RemoveAt(i);
                    break; 
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
            if (!Verification(cif, password))
            {
                users.Add(user);
                SaveUsers();
            }
            else
            {
                MessageBox.Show("CIF o Contraseñas ya ocupadas", "Error de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            files.ReadUser(users);
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

        public User FindUser(int cif)
        {
            foreach (User user in users)
            {
                if ( user.CIF == cif)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
