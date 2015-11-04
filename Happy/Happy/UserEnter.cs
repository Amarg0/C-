using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy.Properties;

namespace Happy
{
    public partial class UserEnter : Form
    {
        public UserEnter()
        {
            InitializeComponent();
            LoginTextbox.Text = Resources.Логин_;
            PasswordTextbox.Text = Resources.Пароль_;
        }

        private void LoginTextbox_Click_1(object sender, EventArgs e)
        {
            if (LoginTextbox.Text == Resources.Логин_)
            {
                LoginTextbox.Text = null;
            }
        }

        private void PasswordTextbox_Click_1(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == Resources.Пароль_)
            {
                PasswordTextbox.Text = null;
            }
        }

        //private void MouseCaptureChanged(object sender, EventArgs e)
        //{
        //    if (LoginTextbox.Text == null)
        //    {
        //        LoginTextbox.Text = Resources.Логин_;
        //    }
        //    if (PasswordTextbox.Text == null)
        //    {
        //        PasswordTextbox.Text = Resources.Пароль_;
        //    }
        //}
    }
}
