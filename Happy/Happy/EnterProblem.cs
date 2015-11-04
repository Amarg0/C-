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
    public partial class EnterProblem : Form
    {
        public EnterProblem()
        {
            InitializeComponent();
        }

        private void GetProblem_Click(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("Отлично, приступим.");
            ProblemHistory problemHistory = new ProblemHistory(ProblemTextBox.Text);
            problemHistory.ShowDialog();
            this.Close();
        }
    }
}
