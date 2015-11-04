using System;
using System.Diagnostics;
using System.Windows.Forms;
using Happy.Properties;

namespace Happy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HappyQuestion.Text == Resources.Form1_button1_Click_Вы_счастливы_)
            {
                HappyQuestion.Text = Resources.Form1_button2_Click_;
            }
            else
            {
                MessageBox.Show("Попробуй ещё раз");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HappyQuestion.Text == Resources.Form1_button1_Click_Вы_счастливы_)
            {
                MessageBox.Show("Молодец! \nПродолжай в том же духе!");
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Hide();
                EnterProblem enterProblem = new EnterProblem();
                enterProblem.ShowDialog();
                this.Close();
            }
        }
    }
}
