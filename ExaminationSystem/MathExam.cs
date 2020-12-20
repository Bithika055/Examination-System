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
    public partial class MathExam : Form
    {
        public MathExam()
        {
            InitializeComponent();
        }

        private void loglabel_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Close();
        }
        public static string username;
        public static string age;
        public static string gender;
        public static string date;
        private void button1_Click(object sender, EventArgs e)
        {
             username = usernametextbox.Text;
             age = agetextbox.Text;
             gender = Gendercombox.Text;
             date = dateTimePicker1.Text;

             Console.Write(username + gender + age);           //  string exam = mathtextbox.Text;
            //---------StartTest MathExam---------------

            if(username!="" && age!="" && gender!="")
            {
                //MessageBox.Show("");
                this.Hide();
                StartTestMathExam exam = new StartTestMathExam();
                exam.Show();
            }
            else
            {
                MessageBox.Show("Fill Up about yourself");
            }
 
        
   
        }

        private void previousmathexambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam m = new Exam();
            m.Show();
        }
    }
}
