using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UamAcces.models
{
    internal class Administration
    {
        public const string Registro = "Ingresados.dat";
        
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
            File.Delete(Registro);
            FileStream WriterFile = new FileStream(Registro, FileMode.Create, FileAccess.Write);
            BinaryWriter Writer = new BinaryWriter(WriterFile);

            foreach (var user in users)
            {
                Writer.Write(user.CIF);
                Writer.Write(user.Name);
                Writer.Write(user.LastName);
                Writer.Write(user.Entry.Ticks);
                Writer.Write(user.Exit.Ticks);
                Writer.Write(user.EntryType);
                Writer.Write(user.Plate);
                Writer.Write(user.EntryPath);
                Writer.Write(user.Time.Ticks);

            }
            Writer.Close();
        
        }

        public void ReadFile()
        {
            if (File.Exists(Registro))
            {
                List<Entrant> users1 = new List<Entrant>();
                FileStream ReadFile = new FileStream(Registro, FileMode.Open, FileAccess.Read);
                BinaryReader Reader = new BinaryReader(ReadFile);

            
                
                while (ReadFile.Position != ReadFile.Length)
                {
                    Entrant user = new Entrant();
                    user.CIF = Reader.ReadInt32();
                    user.Name = Reader.ReadString();
                    user.LastName = Reader.ReadString();
                    long ticks = Reader.ReadInt64();
                    user.Entry = new DateTime(ticks);
                    ticks = Reader.ReadInt64();
                    user.Exit = new DateTime(ticks);
                    user.EntryType = Reader.ReadString();
                    user.Plate = Reader.ReadString();
                    user.EntryPath = Reader.ReadString();
                    ticks = Reader.ReadInt64();
                    user.Time = new TimeSpan(ticks);
                    users1.Add(user);
                }
                Reader.Close();
                users.Clear();
                users = users1;
            }
        }

        public void Update(int cif,DateTime exit, TimeSpan time)
        {
            int index = users.FindIndex(user => user.CIF == cif);
            Entrant user1=users[index];
            user1.Exit= exit;
            user1.Time = time;
            users[index]= user1;
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
                if(user.CIF == cif)
                {
                    return user;
                } 
            }
            MessageBox.Show("Esto esta malo", "malo");
            return null;
        }
    }
}
