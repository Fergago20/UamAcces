using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UamAcces.models
{
    internal class Administrator : Entrant
    {
        public Administrator()
        {
            CIF = 432343;
            Password = 556342;
            Role = "Trabajador";
        }
    }
}
