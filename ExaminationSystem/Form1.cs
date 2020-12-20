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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string usname;
      

        private void logbtn_Click(object sender, EventArgs e)
        {

            string email = emailtextbox.Text;
            string password = passtextbox.Text;
            // Console.Write(username + "," + password);

            SqlConnection connection = new SqlConnection("Data Source= ASUS-PC\\SQLEXPRESS; Initial Catalog=StudentDB; Integrated Security= true");
            connection.Open();
            string insertString = "(select * from tbl_registration where email='" + email + "' and password = '" + password + "')";

            SqlCommand selectcommand = new SqlCommand(insertString, connection);

            SqlDataReader dataFromDb = selectcommand.ExecuteReader();
            if (dataFromDb.HasRows)
            {

                this.Hide();
                Exam ExamForm = new Exam();

                ExamForm.Show();
                usname = emailtextbox.Text;

            }
            else
            {
                MessageBox.Show("Login failed");
            }
            // string userNameFromDb = (string) dataFromDb["username"];
            //string passwordFromDb = (string)dataFromDb["password"];
        }

        private void login_Click(object sender, EventArgs e)
        {
            regigroupbox.Visible = false;
            logingroup.Visible = true;
        }

        private void register_Click(object sender, EventArgs e)
        {
            regigroupbox.Visible = true;
            logingroup.Visible = false;
        }

        private void signlabel_Click(object sender, EventArgs e)
        {
            logingroup.Visible = false;
            regigroupbox.Visible = true;
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            string name = usernametextbox.Text;
            string Email = regiemailtextbox.Text;
            string password = passwordtextbox.Text;
            string conformpassword = confopasstextbox.Text;

            //name validate

            if (name.Any(char.IsLower) && name.Any(char.IsUpper) && !name.Any(char.IsDigit))
            {
                userlabel.ForeColor = Color.Green;
            }
            else
            {
                userlabel.ForeColor = Color.Red;
            }

            //email vatification
            if (!Email.Contains("@gmail.com"))
            { emalabel.ForeColor = Color.Red; }
            else
            {
                emalabel.ForeColor = Color.Green;
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("nigar5924@gmail.com", "01");
                    MailMessage msg = new MailMessage();
                    msg.To.Add(Emaillabel.Text);
                    msg.From = new MailAddress("nigar5924@gmail.com");
                    msg.Subject = "Registration";
                    msg.Body = "Congratulation..your registration has been successfully completed";
                    client.Send(msg);
                    MessageBox.Show("successully send message");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

            //password valid
            //var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };

            if (password == conformpassword)//&& list.Any(password.Contains) && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                passwordlabel.ForeColor = Color.Green;
                confolabel.ForeColor = Color.Green;

            }
            else
            {
                passwordlabel.ForeColor = Color.Red;
                confolabel.ForeColor = Color.Red;
            }

            if ((password == conformpassword &&/* list.Any(password.Contains) && password.Any(char.IsDigit) && password.Any(char.IsLetter)) &&*/ (Email.Contains("@gmail.com")) && name != null && name.Any(char.IsLower) && name.Any(char.IsUpper)))
            {
                SqlConnection connection = new SqlConnection("Data Source= ASUS-PC\\SQLEXPRESS; Initial Catalog=StudentDB; Integrated Security= true");
                connection.Open();
                string insertString = "INSERT INTO tbl_registration(username,email,password) values('" + name + "','" + Email + "','" + password + "')";

                SqlCommand insertcommand = new SqlCommand(insertString, connection);
                insertcommand.ExecuteNonQuery();

            }
            MessageBox.Show("Registration has been successfully!!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel admin = new AdminPanel();
            admin.Show();
        }
    }
}
