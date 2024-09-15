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
        public void GetUserID(string userID)
        {
            if (userID == null)
            {
                MessageBox.Show("Enter an ID");
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
