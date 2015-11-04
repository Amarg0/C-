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
    public partial class RegistrationForm : Form
    {
        UserBase userBase = new UserBase();
        BussinessLayer bussiness = new BussinessLayer();
        public RegistrationForm(object users)
        {
            InitializeComponent();
            LoginTextbox.Text = Resources.RegistrationForm_RegistrationForm_Введите_логин_;
            PasswordTextbox.Text = Resources.RegistrationForm_RegistrationForm_Введите_пароль_;
            Password2Textbox.Text = Resources.RegistrationForm_RegistrationForm_Повторите_пароль_;
            userBase = (UserBase) users;
        }

        private void LoginTextbox_Click_1(object sender, EventArgs e)
        {
            if (LoginTextbox.Text == Resources.RegistrationForm_RegistrationForm_Введите_логин_)
            {
                LoginTextbox.Text = null;
            }
        }

        private void PasswordTextbox_Click_1(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == Resources.RegistrationForm_RegistrationForm_Введите_пароль_)
            {
                PasswordTextbox.Text = null;
            }
        }

        private void Password2Textbox_Click_1(object sender, EventArgs e)
        {
            if (Password2Textbox.Text == Resources.RegistrationForm_RegistrationForm_Повторите_пароль_)
            {
                Password2Textbox.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginTextbox.Text!=null && PasswordTextbox.Text!=null && Password2Textbox.Text!=null)
                bussiness.CreateUser(userBase,LoginTextbox.Text,PasswordTextbox.Text);
        }
    }
}