using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UamAcces.models;

namespace UamAcces.Dao
{
    internal class Filter
    {
        
        public List<User> FilterData( List<User> users, string faculty, string role)
        {
            return users.Where(user =>
         (faculty == "Todos" || user.Faculty == faculty) &&
         (role == "Todos" || user.Role == role))
         .ToList();
        }
    }
}
