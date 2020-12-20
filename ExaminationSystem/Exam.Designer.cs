namespace ExaminationSystem
{
    partial class Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.examgroupbox = new System.Windows.Forms.GroupBox();
            this.examtestgrpbox = new System.Windows.Forms.GroupBox();
            this.EnglishExam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loglabel = new System.Windows.Forms.Label();
            this.examlabel = new System.Windows.Forms.Label();
            this.prolabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.examgroupbox.SuspendLayout();
            this.examtestgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 438);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(853, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // examgroupbox
            // 
            this.examgroupbox.Controls.Add(this.examtestgrpbox);
            this.examgroupbox.Controls.Add(this.pictureBox2);
            this.examgroupbox.Controls.Add(this.label1);
            this.examgroupbox.Location = new System.Drawing.Point(46, 126);
            this.examgroupbox.Name = "examgroupbox";
            this.examgroupbox.Size = new System.Drawing.Size(856, 274);
            this.examgroupbox.TabIndex = 15;
            this.examgroupbox.TabStop = false;
            // 
            // examtestgrpbox
            // 
            this.examtestgrpbox.Controls.Add(this.EnglishExam);
            this.examtestgrpbox.Controls.Add(this.label3);
            this.examtestgrpbox.Controls.Add(this.label2);
            this.examtestgrpbox.Location = new System.Drawing.Point(355, 52);
            this.examtestgrpbox.Name = "examtestgrpbox";
            this.examtestgrpbox.Size = new System.Drawing.Size(459, 203);
            this.examtestgrpbox.TabIndex = 2;
            this.examtestgrpbox.TabStop = false;
            // 
            // EnglishExam
            // 
            this.EnglishExam.AutoSize = true;
            this.EnglishExam.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EnglishExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishExam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EnglishExam.Location = new System.Drawing.Point(194, 128);
            this.EnglishExam.Name = "EnglishExam";
            this.EnglishExam.Size = new System.Drawing.Size(52, 16);
            this.EnglishExam.TabIndex = 2;
            this.EnglishExam.Text = "English";
            this.EnglishExam.Click += new System.EventHandler(this.EnglishExam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(184, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mathematics";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Which subject you want to\r\n choose?\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Online Exam - Start Now";
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loglabel.Location = new System.Drawing.Point(195, 90);
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
            this.examlabel.Location = new System.Drawing.Point(125, 90);
            this.examlabel.Name = "examlabel";
            this.examlabel.Size = new System.Drawing.Size(50, 18);
            this.examlabel.TabIndex = 13;
            this.examlabel.Text = "Exam";
            this.examlabel.Click += new System.EventHandler(this.examlabel_Click);
            // 
            // prolabel
            // 
            this.prolabel.AutoSize = true;
            this.prolabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.prolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prolabel.Location = new System.Drawing.Point(46, 90);
            this.prolabel.Name = "prolabel";
            this.prolabel.Size = new System.Drawing.Size(57, 18);
            this.prolabel.TabIndex = 12;
            this.prolabel.Text = "Profile";
            this.prolabel.Click += new System.EventHandler(this.prolabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 487);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.examgroupbox);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.examlabel);
            this.Controls.Add(this.prolabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exam";
            this.Text = "Exam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.examgroupbox.ResumeLayout(false);
            this.examgroupbox.PerformLayout();
            this.examtestgrpbox.ResumeLayout(false);
            this.examtestgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox examgroupbox;
        private System.Windows.Forms.GroupBox examtestgrpbox;
        private System.Windows.Forms.Label EnglishExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.Label examlabel;
        private System.Windows.Forms.Label prolabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}