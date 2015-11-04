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
        private object UserBase;
        public Logon(object userBase)
        {
            InitializeComponent();
            UserBase = userBase;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            UserEnter userEnter = new UserEnter(UserBase);
            userEnter.ShowDialog();
 
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(UserBase);
            registration.ShowDialog();
            this.Close();
        }
    }
}
