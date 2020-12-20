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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        public static string quesNo;
        public static string ques;
        public static string optA;
        public static string optB;
        public static string optC;
        public static string go = "No";
        private void button1_Click(object sender, EventArgs e)
        {
            ques = adminQuesTextBox.Text;
            optA = adminOptionA.Text;
            optB = adminOptionB.Text;
            optC = adminOptionC.Text;



            if (AdminComboBox.Text == "1")
            {
                quesNo = "1";
            }
            if (AdminComboBox.Text == "2")
            {
                quesNo = "2";
            }
            if (AdminComboBox.Text == "3")
            {
                quesNo = "3";
            }           
            go = "Go";
            MessageBox.Show("question added succesfully");
        }

        private void adlogoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 m = new Form1();
            m.Show();
        }
    }
}
