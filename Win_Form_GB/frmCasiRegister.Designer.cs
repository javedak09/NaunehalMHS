namespace Win_Form_GB
{
    partial class frmCasiRegister
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radiobtn_cr07dob = new System.Windows.Forms.RadioButton();
            this.label_cr05 = new System.Windows.Forms.Label();
            this.label_cr06 = new System.Windows.Forms.Label();
            this.label_cr08 = new System.Windows.Forms.Label();
            this.label_cr09 = new System.Windows.Forms.Label();
            this.label_cr10 = new System.Windows.Forms.Label();
            this.radiobtn_cr07age = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 394);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // radiobtn_cr07dob
            // 
            this.radiobtn_cr07dob.AutoSize = true;
            this.radiobtn_cr07dob.Location = new System.Drawing.Point(14, 99);
            this.radiobtn_cr07dob.Name = "radiobtn_cr07dob";
            this.radiobtn_cr07dob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_cr07dob.Size = new System.Drawing.Size(84, 17);
            this.radiobtn_cr07dob.TabIndex = 14;
            this.radiobtn_cr07dob.TabStop = true;
            this.radiobtn_cr07dob.Text = "Date of Birth";
            this.radiobtn_cr07dob.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radiobtn_cr07dob.UseVisualStyleBackColor = true;
            this.radiobtn_cr07dob.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label_cr05
            // 
            this.label_cr05.AutoSize = true;
            this.label_cr05.Location = new System.Drawing.Point(37, 23);
            this.label_cr05.Name = "label_cr05";
            this.label_cr05.Size = new System.Drawing.Size(61, 13);
            this.label_cr05.TabIndex = 7;
            this.label_cr05.Text = "Child Name";
            this.label_cr05.Click += new System.EventHandler(this.label_cr05_Click);
            // 
            // label_cr06
            // 
            this.label_cr06.AutoSize = true;
            this.label_cr06.Location = new System.Drawing.Point(30, 48);
            this.label_cr06.Name = "label_cr06";
            this.label_cr06.Size = new System.Drawing.Size(68, 13);
            this.label_cr06.TabIndex = 6;
            this.label_cr06.Text = "Father Name";
            this.label_cr06.Click += new System.EventHandler(this.label_cr06_Click);
            // 
            // label_cr08
            // 
            this.label_cr08.AutoSize = true;
            this.label_cr08.Location = new System.Drawing.Point(60, 125);
            this.label_cr08.Name = "label_cr08";
            this.label_cr08.Size = new System.Drawing.Size(38, 13);
            this.label_cr08.TabIndex = 12;
            this.label_cr08.Text = "Height";
            this.label_cr08.Click += new System.EventHandler(this.label_cr08_Click);
            // 
            // label_cr09
            // 
            this.label_cr09.AutoSize = true;
            this.label_cr09.Location = new System.Drawing.Point(57, 150);
            this.label_cr09.Name = "label_cr09";
            this.label_cr09.Size = new System.Drawing.Size(41, 13);
            this.label_cr09.TabIndex = 11;
            this.label_cr09.Text = "Weight";
            this.label_cr09.Click += new System.EventHandler(this.label_cr09_Click);
            // 
            // label_cr10
            // 
            this.label_cr10.AutoSize = true;
            this.label_cr10.Location = new System.Drawing.Point(60, 175);
            this.label_cr10.Name = "label_cr10";
            this.label_cr10.Size = new System.Drawing.Size(38, 13);
            this.label_cr10.TabIndex = 13;
            this.label_cr10.Text = "MAUC";
            this.label_cr10.Click += new System.EventHandler(this.label_cr10_Click);
            // 
            // radiobtn_cr07age
            // 
            this.radiobtn_cr07age.AutoSize = true;
            this.radiobtn_cr07age.Location = new System.Drawing.Point(54, 73);
            this.radiobtn_cr07age.Name = "radiobtn_cr07age";
            this.radiobtn_cr07age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobtn_cr07age.Size = new System.Drawing.Size(44, 17);
            this.radiobtn_cr07age.TabIndex = 15;
            this.radiobtn_cr07age.TabStop = true;
            this.radiobtn_cr07age.Text = "Age";
            this.radiobtn_cr07age.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radiobtn_cr07age.UseVisualStyleBackColor = true;
            this.radiobtn_cr07age.CheckedChanged += new System.EventHandler(this.radiobtn_cr07age_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(128, 125);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(128, 150);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(154, 20);
            this.textBox9.TabIndex = 16;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(128, 176);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(154, 20);
            this.textBox10.TabIndex = 16;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(128, 72);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(154, 20);
            this.textBox8.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.radiobtn_cr07age);
            this.tabPage1.Controls.Add(this.label_cr10);
            this.tabPage1.Controls.Add(this.label_cr09);
            this.tabPage1.Controls.Add(this.label_cr08);
            this.tabPage1.Controls.Add(this.label_cr06);
            this.tabPage1.Controls.Add(this.label_cr05);
            this.tabPage1.Controls.Add(this.radiobtn_cr07dob);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // frmCasiRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 417);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCasiRegister";
            this.Text = "frmCasiRegister";
            this.Load += new System.EventHandler(this.frmCasiRegister_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radiobtn_cr07age;
        private System.Windows.Forms.Label label_cr10;
        private System.Windows.Forms.Label label_cr09;
        private System.Windows.Forms.Label label_cr08;
        private System.Windows.Forms.Label label_cr06;
        private System.Windows.Forms.Label label_cr05;
        private System.Windows.Forms.RadioButton radiobtn_cr07dob;
    }
}