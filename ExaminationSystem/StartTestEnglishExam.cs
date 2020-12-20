using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Net.Mime;
using System.Threading;
using System.Data.Sql;
using System.Net;

namespace ExaminationSystem
{
    public partial class StartTestEnglishExam : Form
    {
        public StartTestEnglishExam()
        {
            InitializeComponent();
        }

        private void loglabel_Click(object sender, EventArgs e)
        {

            Form1 m = new Form1();
            m.Show();
            this.Close();
        }

        private void btnengsubmit_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //            timer1.Start();
            // timer1.Stop(); 
            //math
            // string email = Form1.usname;
            string name = EnglishExam.username;
            string age = EnglishExam.age;
            string gender = EnglishExam.gender;
            string date = EnglishExam.date;
            string exam = englishtextbox.Text;
            try
            {
                int engmarks = 0;
                SqlConnection connection = new SqlConnection("Data Source= ASUS-PC\\SQLEXPRESS; Initial Catalog=StudentDB; Integrated Security= true");
                connection.Open();


                string ans1, ans2, ans3;

                if (radioButton16.Checked)
                    ans1 = radioButton16.Text;
                else if (radioButton17.Checked)
                    ans1 = radioButton17.Text;
                else if (radioButton18.Checked)
                    ans1 = radioButton18.Text;
                else
                    ans1 = null;
                string selectString = "select * from engans where ques ='1' and ans = '" + ans1 + "'";
                SqlCommand cmd = new SqlCommand(selectString, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    engmarks = engmarks + 1;
                }
                connection.Close();
                if (radioButton13.Checked)
                    ans2 = radioButton13.Text;
                else if (radioButton14.Checked)
                    ans2 = radioButton14.Text;
                else if (radioButton15.Checked)
                    ans2 = radioButton15.Text;
                else
                    ans2 = null;
                connection.Open();
                string selectStr = "select * from engans where ques ='2' and ans = '" + ans2 + "'";
                SqlCommand cmnd = new SqlCommand(selectStr, connection);
                SqlDataReader redr = cmnd.ExecuteReader();
                if (redr.HasRows)
                {
                    engmarks = engmarks + 1;
                }

                connection.Close();
                if (radioButton10.Checked)
                    ans3 = radioButton10.Text;
                else if (radioButton11.Checked)
                    ans3 = radioButton11.Text;
                else if (radioButton12.Checked)
                    ans3 = radioButton12.Text;
                else
                    ans3 = null;
                connection.Open();
                string slctStr = "select * from engans where ques = '3' and ans = '" + ans3 + "'";
                SqlCommand comd = new SqlCommand(slctStr, connection);
                SqlDataReader readr = comd.ExecuteReader();
                if (readr.HasRows)
                {
                    engmarks = engmarks + 1;

                }

                connection.Close();
                //  Console.WriteLine(ans1 + " " + ans2 );

                MessageBox.Show("Your marks is = " + engmarks);

                connection.Open();
                string insString = "insert into tbl_student(Username,Age,Gender,Date,Marks,Exam)values('" + name + "','" + age + "','" + gender + "','" + date + "','" + engmarks + "','" + exam + "')";
                SqlCommand insertcommand = new SqlCommand(insString, connection);
                insertcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "invalid try");
            }

            this.Hide();
            SubmitEngExam eexam = new SubmitEngExam();
            eexam.Show();
        }

        private void StartTestEnglishExam_Load(object sender, EventArgs e)
        {
            string ques_no = AdminPanel.quesNo;
            string ques = AdminPanel.ques;
            string opt1 = AdminPanel.optA;
            string opt2 = AdminPanel.optB;
            string opt3 = AdminPanel.optC;
            string signal = AdminPanel.go;

            if (signal == "Go")
            {
                if (ques_no == "1")
                {
                    groupBox7.Text = ques;
                    radioButton16.Text = opt1;
                    radioButton17.Text = opt2;
                    radioButton18.Text = opt3;
                }
                if (ques_no == "2")
                {
                    groupBox6.Text = ques;
                    radioButton13.Text = opt1;
                    radioButton14.Text = opt2;
                    radioButton15.Text = opt3;
                }
                if (ques_no == "3")
                {
                    groupBox6.Text = ques;
                    radioButton10.Text = opt1;
                    radioButton11.Text = opt2;
                    radioButton12.Text = opt3;
                }


            }
        }
    }
}
