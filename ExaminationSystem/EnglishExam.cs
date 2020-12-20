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
    public partial class EnglishExam : Form
    {
        public EnglishExam()
        {
            InitializeComponent();
        }
        public static string username;
        public static string age;
        public static string gender;
        public static string date;
        private void button1_Click(object sender, EventArgs e)
        {
            //starttest button click
            username = usernametextbox.Text;
            age = agetextbox.Text;
            gender = Gendercombox.Text;
            date = dateTimePicker1.Text;
            //  string exam = mathtextbox.Text;
            //---------StartTest MathExam---------------
            if (username != " " && age != " " && gender != " ")
            {
                //MessageBox.Show("");
                this.Hide();
                StartTestEnglishExam exam = new StartTestEnglishExam();
                exam.Show();
            }
            else
            {
                MessageBox.Show("Fill Up about yourself");
            }
            // this.Hide();
            //StartTestMathExam exam = new StartTestMathExam();
            //exam.Show();
            //  timer1.Enabled = true;
            // timer1.Start();

        }

        private void loglabel_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Close();
        }
    }
}
