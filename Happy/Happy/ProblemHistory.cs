using System;
using System.Drawing;
using System.Windows.Forms;

namespace Happy
{
    public partial class ProblemHistory : Form
    {
        private string Problem { get; set; }

        public ProblemHistory(string problem)
        {
            Problem = problem;
            InitializeComponent();
        }

        private void ProblemHistory_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Green;
            MainProblem.Text += "\n" + Problem;
            CurrentProblem.Text += "\n" + Problem;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
