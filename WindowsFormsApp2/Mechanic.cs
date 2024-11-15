using Assignment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Mechanic : User
    {
        public SQLiteConnection connection;

        public Mechanic()
        {
            connection = GetDatabaseConnection();

        }
       
    }
}
