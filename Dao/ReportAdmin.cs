using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UamAcces.models;

namespace UamAcces.Dao
{
    internal class ReportAdmin
    {
        public List<Entrant> Organize(List<Entrant> entrants, DateTime date1, DateTime date2, string role)
        {
            List<Entrant> entrants2 = new List<Entrant>();
            foreach (var entrant in entrants)
            {

                if (entrant.Role == role && (entrant.Entry < date2 && entrant.Entry > date1))
                {
                    entrants2.Add(entrant);
                }
            }
            return entrants2;
        }

        public List<Entrant> Organize2(List<Entrant>entrants, string role)
        {
            List<Entrant> entrants2 = new List<Entrant>();
            foreach (var entrant in entrants)
            {

                if (entrant.Role == role && entrant.Exit == DateTime.MinValue)
                {
                    entrants2.Add(entrant);
                }
            }
            return entrants2;
        }
    }
}
