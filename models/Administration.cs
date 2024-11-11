﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UamAcces.models
{
    internal class Administration
    {
        List<User> users=new List<User>();

        public void Change(List<User> use)
        {
            users.Clear();
            users.AddRange(use);
        }

        public void Add(User user)
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

        public List<User> GetUsers() { return users; }

        public void SaveFile(User user, string tipo)
        {
            FileStream WriterFile = new FileStream(tipo, FileMode.Append, FileAccess.Write);
            BinaryWriter Writer = new BinaryWriter(WriterFile);

            Writer.Write(user.CIF);
            Writer.Write(user.Role);
            Writer.Write(user.Entry.Ticks);
            Writer.Write(user.Exit.Ticks);
            Writer.Write(user.EntryType);
            Writer.Write(user.EntryPath);
            Writer.Close();
        }

        public List<User> ReadFile(string tipo)
        {
            List<User> users = new List<User>();
            FileStream ReadFile = new FileStream(tipo, FileMode.Open, FileAccess.Read);
            BinaryReader Reader = new BinaryReader(ReadFile);

            User user = new User();
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

        public void Update(int cif,DateTime exit, string tipo)
        {
            FileStream File = new FileStream(tipo, FileMode.Open, FileAccess.ReadWrite);
            BinaryWriter Writer = new BinaryWriter(File);
            BinaryReader Reader = new BinaryReader(File);

            User user = new User();
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


    }
}
