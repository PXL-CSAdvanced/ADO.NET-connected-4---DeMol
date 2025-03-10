using DeMolClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMolClassLibrary.DataAccess
{
    public static class SpelerData
    {
        private static Speler IngelogdeSpeler { get; set; }

        // secure met SqlParameter
        public static bool IsValidLogin(string username, string password)
        {
            
        }

        // ' or '1' = '1
        public static bool IsValidLoginSQLi(string username, string password)
        {
            
        }

        public static Spel GetSpelById(int spelId)
        {
           
        }
    }
}
