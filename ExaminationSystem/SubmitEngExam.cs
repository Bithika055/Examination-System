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
    public partial class SubmitEngExam : Form
    {
        public SubmitEngExam()
        {
            InitializeComponent();
        }

        private void loglabel_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Close();
        }

        private void engviewbtn_Click(object sender, EventArgs e)
        {
            engviewlabel.Visible = true;
        }

        private void Startagainebtn_Click(object sender, EventArgs e)
        {
            StartTestEnglishExam eng = new StartTestEnglishExam();
            eng.Show();
            this.Close();
        }


    }
}
