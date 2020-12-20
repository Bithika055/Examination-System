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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }

        private void examlabel_Click(object sender, EventArgs e)
        {
           // profigroupbox.Visible = false;
            examgroupbox.Visible = true;
        }

        private void loglabel_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Mathematics exam click
            this.Hide();
            MathExam exam = new MathExam();
            exam.Show();
        }

        private void EnglishExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishExam exam = new EnglishExam();
            exam.Show();
        }

        private void prolabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p = new Profile();
            p.Show();
        }
    }
}
