using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class SubmitMathExam : Form
    {
        public SubmitMathExam()
        {
            InitializeComponent();
        }

        private void Viewansbtn_Click(object sender, EventArgs e)
        {
            viewanslabel.Visible = true;
        }

        private void loglabel_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Close();
        }

        private void Startagainmbtn_Click(object sender, EventArgs e)
        {
            StartTestMathExam math = new StartTestMathExam();
            math.Show();
            this.Close();
        }

        private void previoussubmitmathexambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartTestMathExam m = new StartTestMathExam();
            m.Show();
        }
    }
}
