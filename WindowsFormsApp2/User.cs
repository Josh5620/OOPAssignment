using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class User
    {
        public User() { } 
        public string Name { get; set; }
        public string Password { get; set; }
        
        public void Test(string test)
        {
            MessageBox.Show($"Here is {test}");
        }
    }
}
