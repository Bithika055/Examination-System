namespace ExaminationSystem
{
    partial class MathExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathExam));
            this.mathstartgbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.aboutgbox = new System.Windows.Forms.GroupBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Gendercombox = new System.Windows.Forms.ComboBox();
            this.agetextbox = new System.Windows.Forms.TextBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.loglabel = new System.Windows.Forms.Label();
            this.examlabel = new System.Windows.Forms.Label();
            this.prolabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previousmathexambtn = new System.Windows.Forms.Button();
            this.mathstartgbox.SuspendLayout();
            this.aboutgbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mathstartgbox
            // 
            this.mathstartgbox.Controls.Add(this.previousmathexambtn);
            this.mathstartgbox.Controls.Add(this.button1);
            this.mathstartgbox.Controls.Add(this.label10);
            this.mathstartgbox.Controls.Add(this.aboutgbox);
            this.mathstartgbox.Controls.Add(this.label9);
            this.mathstartgbox.Location = new System.Drawing.Point(54, 119);
            this.mathstartgbox.Name = "mathstartgbox";
            this.mathstartgbox.Size = new System.Drawing.Size(818, 344);
            this.mathstartgbox.TabIndex = 16;
            this.mathstartgbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(228, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(357, 80);
            this.label10.TabIndex = 2;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // aboutgbox
            // 
            this.aboutgbox.Controls.Add(this.usernametextbox);
            this.aboutgbox.Controls.Add(this.userlabel);
            this.aboutgbox.Controls.Add(this.dateTimePicker1);
            this.aboutgbox.Controls.Add(this.Gendercombox);
            this.aboutgbox.Controls.Add(this.agetextbox);
            this.aboutgbox.Controls.Add(this.datelabel);
            this.aboutgbox.Controls.Add(this.genderlabel);
            this.aboutgbox.Controls.Add(this.agelabel);
            this.aboutgbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutgbox.Location = new System.Drawing.Point(45, 71);
            this.aboutgbox.Name = "aboutgbox";
            this.aboutgbox.Size = new System.Drawing.Size(753, 112);
            this.aboutgbox.TabIndex = 1;
            this.aboutgbox.TabStop = false;
            this.aboutgbox.Text = "Fill up about yourself";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextbox.Location = new System.Drawing.Point(127, 41);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(121, 24);
            this.usernametextbox.TabIndex = 9;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(31, 44);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(85, 18);
            this.userlabel.TabIndex = 8;
            this.userlabel.Text = "Username";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 24);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Gendercombox
            // 
            this.Gendercombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendercombox.FormattingEnabled = true;
            this.Gendercombox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gendercombox.Location = new System.Drawing.Point(131, 79);
            this.Gendercombox.Name = "Gendercombox";
            this.Gendercombox.Size = new System.Drawing.Size(121, 26);
            this.Gendercombox.TabIndex = 6;
            // 
            // agetextbox
            // 
            this.agetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetextbox.Location = new System.Drawing.Point(641, 41);
            this.agetextbox.Name = "agetextbox";
            this.agetextbox.Size = new System.Drawing.Size(100, 24);
            this.agetextbox.TabIndex = 4;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(587, 87);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(43, 18);
            this.datelabel.TabIndex = 3;
            this.datelabel.Text = "Date";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(53, 82);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(63, 18);
            this.genderlabel.TabIndex = 2;
            this.genderlabel.Text = "Gender";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabel.Location = new System.Drawing.Point(587, 47);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(36, 18);
            this.agelabel.TabIndex = 1;
            this.agelabel.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Welcome To Online Exam";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(54, 469);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(853, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loglabel.Location = new System.Drawing.Point(181, 83);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(60, 18);
            this.loglabel.TabIndex = 14;
            this.loglabel.Text = "Logout";
            this.loglabel.Click += new System.EventHandler(this.loglabel_Click);
            // 
            // examlabel
            // 
            this.examlabel.AutoSize = true;
            this.examlabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.examlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examlabel.Location = new System.Drawing.Point(111, 83);
            this.examlabel.Name = "examlabel";
            this.examlabel.Size = new System.Drawing.Size(50, 18);
            this.examlabel.TabIndex = 13;
            this.examlabel.Text = "Exam";
            // 
            // prolabel
            // 
            this.prolabel.AutoSize = true;
            this.prolabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.prolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prolabel.Location = new System.Drawing.Point(32, 83);
            this.prolabel.Name = "prolabel";
            this.prolabel.Size = new System.Drawing.Size(57, 18);
            this.prolabel.TabIndex = 12;
            this.prolabel.Text = "Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // previousmathexambtn
            // 
            this.previousmathexambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousmathexambtn.Location = new System.Drawing.Point(231, 311);
            this.previousmathexambtn.Name = "previousmathexambtn";
            this.previousmathexambtn.Size = new System.Drawing.Size(90, 27);
            this.previousmathexambtn.TabIndex = 17;
            this.previousmathexambtn.Text = "Previous";
            this.previousmathexambtn.UseVisualStyleBackColor = true;
            this.previousmathexambtn.Click += new System.EventHandler(this.previousmathexambtn_Click);
            // 
            // MathExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 517);
            this.Controls.Add(this.mathstartgbox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.examlabel);
            this.Controls.Add(this.prolabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MathExam";
            this.Text = "MathExam";
            this.mathstartgbox.ResumeLayout(false);
            this.mathstartgbox.PerformLayout();
            this.aboutgbox.ResumeLayout(false);
            this.aboutgbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mathstartgbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox aboutgbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Gendercombox;
        private System.Windows.Forms.TextBox agetextbox;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.Label examlabel;
        private System.Windows.Forms.Label prolabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Button previousmathexambtn;
    }
}