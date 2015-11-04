using System;
using System.Drawing;
using System.Windows.Forms;
using Happy.Properties;

namespace Happy
{
    public partial class ProblemHistory : Form
    {
        private Problem[] _problems;
        private int _currentProblemNumber = 1;

        public ProblemHistory(object problemsobj)
        {
            _problems = (Problem[]) problemsobj;
            InitializeComponent();
        }

        private void ProblemHistory_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Green;
            MainProblem.Text = Resources.ProblemHistory_ProblemHistory_Load_Главная_проблема_ + _problems[0].Name;
            CurrentProblem.Text = Resources.ProblemHistory_ProblemHistory_Load_ + _problems[1].Name;
            CurrentStatus.Text = Resources.ProblemHistory_ProblemHistory_Load_Статус_ + _problems[1].ProblemStatus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentProblemNumber + 1 == _problems.Length) return;
            _currentProblemNumber++;
            CurrentProblem.Text = Resources.ProblemHistory_ProblemHistory_Load_ +
                                  _problems[_currentProblemNumber].Name;
            CurrentStatus.Text = Resources.ProblemHistory_ProblemHistory_Load_Статус_ +
                                 _problems[_currentProblemNumber].ProblemStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_currentProblemNumber == 1) return;
            _currentProblemNumber--;
            CurrentProblem.Text = Resources.ProblemHistory_ProblemHistory_Load_ +
                                  _problems[_currentProblemNumber].Name;
            CurrentStatus.Text = Resources.ProblemHistory_ProblemHistory_Load_Статус_ +
                                 _problems[_currentProblemNumber].ProblemStatus();
        }
    }
}
