using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{ 
    public class Admin : User
    {
       private SQLiteConnection connection;
       private SQLiteDataAdapter dataAdapter;

        public Admin()
        {
            //Get the database connection from User class
            connection = GetDatabaseConnection();
        }
    }
}
