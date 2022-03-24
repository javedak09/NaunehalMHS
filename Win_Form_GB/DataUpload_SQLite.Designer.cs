
namespace Win_Form_GB
{
    partial class DataUpload_SQLite
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
            this.cmdUpload = new System.Windows.Forms.Button();
            this.cmdUpload1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUpload
            // 
            this.cmdUpload.Location = new System.Drawing.Point(32, 33);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(141, 23);
            this.cmdUpload.TabIndex = 0;
            this.cmdUpload.Text = "Upload Forms4mm";
            this.cmdUpload.UseVisualStyleBackColor = true;
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // cmdUpload1
            // 
            this.cmdUpload1.Location = new System.Drawing.Point(32, 62);
            this.cmdUpload1.Name = "cmdUpload1";
            this.cmdUpload1.Size = new System.Drawing.Size(141, 23);
            this.cmdUpload1.TabIndex = 1;
            this.cmdUpload1.Text = "Upload Forms21cm";
            this.cmdUpload1.UseVisualStyleBackColor = true;
            this.cmdUpload1.Click += new System.EventHandler(this.cmdUpload1_Click);
            // 
            // DataUpload_SQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 134);
            this.Controls.Add(this.cmdUpload1);
            this.Controls.Add(this.cmdUpload);
            this.Name = "DataUpload_SQLite";
            this.Text = "DataUpload_SQLite";
            this.Load += new System.EventHandler(this.DataUpload_SQLite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUpload;
        private System.Windows.Forms.Button cmdUpload1;
    }
}