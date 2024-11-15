using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UamAcces.models
{
    public class User
    {
        public int CIF { get; set; }
        public int Password {  get; set; }
        public string Name {  get; set; }
        public string LastName { get; set; }
        public string Faculty {  get; set; }
        public string Role {  get; set; }
        private string reason;
        public string Reason
        {
            get
            {
                return
                string.IsNullOrEmpty(reason) ? "Ligado a institución" : reason;
            }
            set
            {
                reason = value;
            }
        }
    }
}
