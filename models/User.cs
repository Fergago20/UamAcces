using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UamAcces.models
{
    internal class User
    {
        public int CIF { get; set; }
        public int Password { get; set; }
        public string Role { get; set; }
        public DateTime Entry {  get; set; }
        public DateTime Exit {  get; set; }
        public string EntryType {  get; set; }
        public int EntryPath {  get; set; }
        public string Facultad {  get; set; }
        public bool Validar(int cif, int password)
        {
            return cif == CIF && password == Password;
        }
        
        
    }
}
