using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            UserEnter userEnter = new UserEnter();
            userEnter.ShowDialog();
 
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
        }
    }
}
