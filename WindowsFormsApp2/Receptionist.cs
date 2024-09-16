using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Receptionist : User
    {
        public void GetUserID(string userID) // also let accept another argument to know to cehck which database
        {
            if (userID == null || userID == "")
            {
                MessageBox.Show("ID not found");
                return;
            }
            FocusID = userID;
            
        }
        private string focusID;
        public string FocusID
        {
            get { return focusID; }
            private set { focusID = value; }
        }
    
        





    }
}
