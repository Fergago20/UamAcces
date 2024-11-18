using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UamAcces.models;

namespace UamAcces.Archivos
{
    internal class AllFile
    {
        const string Joined = "Ingresados.dat";
        const string Registro = "Registro.dat";
        public void ReadFile(List<Entrant> users)
        {
            if (File.Exists(Joined))
            {
                List<Entrant> users1 = new List<Entrant>();
                FileStream ReadFile = new FileStream(Joined, FileMode.Open, FileAccess.Read);
                BinaryReader Reader = new BinaryReader(ReadFile);



                while (ReadFile.Position != ReadFile.Length)
                {
                    Entrant user = new Entrant();
                    user.CIF = Reader.ReadInt32();
                    user.Name = Reader.ReadString();
                    user.LastName = Reader.ReadString();
                    user.Role = Reader.ReadString();
                    user.Faculty = Reader.ReadString();
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
                users.AddRange(users1);

            }


        }

        public void SaveFile(List<Entrant> users)
        {
            File.Delete(Joined);
            FileStream WriterFile = new FileStream(Joined, FileMode.Create, FileAccess.Write);
            BinaryWriter Writer = new BinaryWriter(WriterFile);

            foreach (var user in users)
            {
                Writer.Write(user.CIF);
                Writer.Write(user.Name);
                Writer.Write(user.LastName);
                Writer.Write(user.Role);
                Writer.Write(user.Faculty);
                Writer.Write(user.Entry.Ticks);
                Writer.Write(user.Exit.Ticks);
                Writer.Write(user.EntryType);
                Writer.Write(user.Plate);
                Writer.Write(user.EntryPath);
                Writer.Write(user.Time.Ticks);

            }
            Writer.Close();

        }

         public void SaveUsers(List<User> users)
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

        public void ReadUser(List<User> users)
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
                users.AddRange(users2);

            }
        }
    }
}
