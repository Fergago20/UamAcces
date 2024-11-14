using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UamAcces.models
{
    internal class Administration
    {
        public const string Registro = "Registro.dat";
        
        List<Entrant> users=new List<Entrant>();

        public void Change(List<Entrant> use)
        {
            users.Clear();
            users.AddRange(use);
        }

        public void Add(Entrant user)
        {
            users.Add(user);
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

        public void SaveFile(Entrant user)
        {
            FileStream WriterFile = new FileStream(Registro, FileMode.Append, FileAccess.Write);
            BinaryWriter Writer = new BinaryWriter(WriterFile);

            Writer.Write(user.CIF);
            Writer.Write(user.Role);
            Writer.Write(user.Name);
            Writer.Write(user.LastName);
            Writer.Write(user.Entry.Ticks);
            Writer.Write(user.Exit.Ticks);
            Writer.Write(user.EntryType);
            Writer.Write(user.EntryPath);
            Writer.Close();
        }

        public List<Entrant> ReadFile()
        {
            List<Entrant> users = new List<Entrant>();
            FileStream ReadFile = new FileStream(Registro, FileMode.Open, FileAccess.Read);
            BinaryReader Reader = new BinaryReader(ReadFile);

            Entrant user = new Entrant();
            while(ReadFile.Position != ReadFile.Length)
            {
                user.CIF = Reader.ReadInt32();
                user.Role = Reader.ReadString();
                long ticks = Reader.ReadInt64();
                user.Entry = new DateTime(ticks);
                ticks = Reader.ReadInt64();
                user.Exit = new DateTime(ticks);
                user.EntryType = Reader.ReadString();
                user.EntryPath = Reader.ReadInt32();
                users.Add(user);
            }
            Reader.Close();
            return users;
        }

        public void Update(int cif,DateTime exit)
        {
            FileStream File = new FileStream(Registro, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter Writer = new BinaryWriter(File);
            BinaryReader Reader = new BinaryReader(File);

            Entrant user = new Entrant();
            while (File.Position != File.Length)
            {
                user.CIF = Reader.ReadInt32();
                user.Role = Reader.ReadString();
                long ticks = Reader.ReadInt64();
                user.Entry = new DateTime(ticks);
                ticks = Reader.ReadInt64();
                user.Exit = new DateTime(ticks);
                user.EntryType = Reader.ReadString();
                user.EntryPath = Reader.ReadInt32();

                if(user.CIF == cif && user.Exit == null)
                {
                    File.Seek(File.Position, SeekOrigin.Begin);
                    Writer.Write(user.CIF);
                    Writer.Write(user.Role);
                    Writer.Write(user.Entry.Ticks);
                    Writer.Write(exit.Ticks);
                    user.EntryType = Reader.ReadString();
                    user.EntryPath = Reader.ReadInt32();
                }
            }
            Reader.Close();
            Writer.Close();
        }

        public bool DataVerification(int value, string type)
        {
            List<Entrant> users = ReadFile();

            if (type == "cif")
            {
                foreach (Entrant user in users)
                {
                    if(user.CIF==value) return true;
                }
                return false;
            }

            if (type == "pasword")
            {
                foreach(Entrant user in users)
                {
                    if(user.Password==value) return true;
                }
                return false;
            }
            return false ;
        }


    }
}
