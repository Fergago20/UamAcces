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

                bool roleMatches = role == "Todos" || entrant.Role == role;

                bool dateInRange = entrant.Entry > date1 && entrant.Entry < date2;

                if (roleMatches && dateInRange)
                {
                    entrants2.Add(entrant);
                }
            }
            return entrants2;
        }

        public List<Entrant> Organize2(List<Entrant> entrants, string role)
        {
            List<Entrant> entrants2 = new List<Entrant>();

            foreach (var entrant in entrants)
            {
                
                if (role == "Todos" && entrant.Exit == DateTime.MinValue)
                {
                    entrants2.Add(entrant);
                }
                
                else if (entrant.Role == role && entrant.Exit == DateTime.MinValue)
                {
                    entrants2.Add(entrant);
                }
            }

            return entrants2;
        }


        public void BubbleSort(List<Entrant> entrants)
        {
            bool swapped;
            
            for (int i = 0; i < entrants.Count - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < entrants.Count - i - 1; j++)
                {
                    if (entrants[j].Entry > entrants[j + 1].Entry)
                    {
                        
                        var temp = entrants[j];
                        entrants[j] = entrants[j + 1];
                        entrants[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
    }
}
