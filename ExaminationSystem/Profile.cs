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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void updtebtn_Click(object sender, EventArgs e)
        {
            string email = Form1.usname;
            try
            {
               // string updateImageLocation = updateimagebox.Text;
                SqlConnection dbCon = new SqlConnection("Data Source=ASUS-PC\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=true");
             //  SqlCommand updateCommand = new SqlCommand("Update tbl_student SET name=@StudentName,roll=@StudentRoll,reg=@StudentReg,faculty=@StudentFaculty where reg='" + updateSerachBox.Text + "'", dbCon);
                 SqlCommand updateCommand = new SqlCommand("Update tbl_registration where email='"+email+"', dbCon");
                    updateCommand.Parameters.AddWithValue("@Userame", usernametextbox.Text);
                    updateCommand.Parameters.AddWithValue("@Email", regiemailtextbox.Text);
                    updateCommand.Parameters.AddWithValue("@Password",passwordtextbox.Text);
                    if (dbCon.State == ConnectionState.Closed)
                        dbCon.Open();
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show(" Updated  Successfully");

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

