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
        BussinessLayer bussiness = new BussinessLayer();
        private UserBase userBase;
        User CurrentUser = new User();
        public UserEnter(object userbase)
        {
            InitializeComponent();
            LoginTextbox.Text = Resources.Логин_;
            PasswordTextbox.Text = Resources.Пароль_;
            userBase = (UserBase) userbase;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (bussiness.Enter(userBase, LoginTextbox.Text, PasswordTextbox.Text))
            {
                MessageBox.Show("С возвращением, " + LoginTextbox.Text+"!");
                Problem[] testProblems = new Problem[5];
                testProblems[0]=new Problem(false,"Главная проблема","Доп. инф. к главной");
                for (int i = 1; i < 5; i++)
                {
                    testProblems[i] = new Problem(false,"Проблема #" +i.ToString(),"доп. инф к " + i.ToString());
                }
                string TestUserProblem = "Проблема пользователя " + LoginTextbox.Text;
                ProblemHistory problemHistory = new ProblemHistory(testProblems);
                this.Hide();
                problemHistory.ShowDialog();
                this.Close();
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
