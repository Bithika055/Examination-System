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
    public partial class StartTestMathExam : Form
    {
        public StartTestMathExam()
        {
            InitializeComponent();
        }
        
       

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            //math
           // string email = Form1.usname;
            string name = MathExam.username;
            string age = MathExam.age;
            string gender = MathExam.gender;
            string date = MathExam.date;
            string exam = mathtextbox.Text;
            //Console.WriteLine(email);
            try
            {


                int marks = 0;
                SqlConnection connection = new SqlConnection("Data Source= ASUS-PC\\SQLEXPRESS; Initial Catalog=StudentDB; Integrated Security= true");
                connection.Open();


                string ans1, ans2, ans3;

                if (radioButton1.Checked)
                    ans1 = radioButton1.Text;
                else if (radioButton2.Checked)
                    ans1 = radioButton2.Text;
                else if (radioButton3.Checked)
                    ans1 = radioButton3.Text;
                else
                    ans1 = null;
                string selectString = "select * from answer where ques ='1' and answer = '" + ans1 + "'";
                SqlCommand cmd = new SqlCommand(selectString, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    marks = marks + 1;
                }
                connection.Close();


                if (radioButton4.Checked)
                    ans2 = radioButton4.Text;
                else if (radioButton5.Checked)
                    ans2 = radioButton5.Text;
                else if (radioButton6.Checked)
                    ans2 = radioButton6.Text;
                else
                    ans2 = null;
                connection.Open();
                string selectStr = "select * from answer where ques ='2' and answer = '" + ans2 + "'";
                SqlCommand cmnd = new SqlCommand(selectStr, connection);
                SqlDataReader redr = cmnd.ExecuteReader();
                if (redr.HasRows)
                {
                    marks = marks + 1;
                }

                connection.Close();


                if (radioButton7.Checked)
                    ans3 = radioButton7.Text;
                else if (radioButton8.Checked)
                    ans3 = radioButton8.Text;
                else if (radioButton9.Checked)
                    ans3 = radioButton9.Text;
                else
                    ans3 = null;
                connection.Open();

                string slctStr = "select * from answer where ques = '3' and answer = '" + ans3 + "'";
                SqlCommand comd = new SqlCommand(slctStr, connection);
                SqlDataReader readr = comd.ExecuteReader();
                if (readr.HasRows)
                {
                    marks = marks + 1;

                }

                connection.Close();

                //  Console.WriteLine(ans1 + " " + ans2 );

                MessageBox.Show("Your marks is = " + marks);

                connection.Open();
                string insStr = "insert into tbl_student(Username,Age,Gender,Date,Marks,Exam)values('" + name + "','" + age + "','" + gender + "','" + date + "','" + marks + "','" + exam + "')";
                SqlCommand insertcmd = new SqlCommand(insStr, connection);
                insertcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "invalid try");
            }
          
            
            this.Hide();
            SubmitMathExam mexam = new SubmitMathExam();
            mexam.Show();
        }

        private void loglabel_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Close();
        }

        private void previousstarttestmathexambtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathExam m = new MathExam();
            m.Show();
        }

    }
}
