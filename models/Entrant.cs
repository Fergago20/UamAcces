using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UamAcces.models
{
    public class Entrant : User
    { 
        public DateTime Entry {  get; set; }
        private DateTime exit;
        public DateTime Exit
        {
            get
            {
                return exit==null ? DateTime.MinValue : exit;
            }
            set
            {
                exit = value;
            }
        }
        public string EntryType {  get; set; }
        private string plate;
        public string Plate
        {
            get
            {
                return string.IsNullOrEmpty(plate) ? "Peatón" : plate;
            }
            set
            {
                plate = value;
            }
        }
        public string EntryPath {  get; set; }
        private TimeSpan time;
        public TimeSpan Time
        {
            get
            {
                return time==null ? TimeSpan.Zero : time;
            }
            set
            {
                time = value;
            }
        }
       
        public bool Validar(int cif, int password)
        {
            return cif == CIF && password == Password;
        }
        
        
    }
}
