using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UamAcces.Archivos;

namespace UamAcces.models
{
    internal class Administration
    {
        public const string Registro = "Ingresados.dat";
        AllFile files = new AllFile();
        
        List<Entrant> users=new List<Entrant>();

        public void Add(Entrant user)
        {
            users.Add(user);
            SaveFile();
        }

        public void Delete(int cif) 
        {
            foreach (var user in users)
            {
                if (cif == user.CIF)
                {
                    users.Remove(user);
                }
            }
        }

        public List<Entrant> GetUsers() { return users; }

        public void SaveFile()
        {
            files.SaveFile(users);
        
        }

        public void ReadFile()
        {
           files.ReadFile(users);
        }

        public void Update(int cif,DateTime exit, TimeSpan time)
        {
            int index = users.FindIndex(user => user.CIF == cif&& user.Exit==DateTime.MinValue);
            users[index].Exit = exit;
            users[index].Time = time;
            SaveFile();
        }

        public bool DataVerification(int cif)
        {
            if (File.Exists(Registro))
            {
                foreach (Entrant user in users)
                {
                    if (user.CIF == cif && user.Exit == DateTime.MinValue)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public Entrant GetUser(int cif)
        {
            foreach(Entrant user in users)
            {
                if(user.CIF == cif && user.Exit==DateTime.MinValue)
                {
                    return user;
                } 
            }
           
            return null;
        }
    }
}
