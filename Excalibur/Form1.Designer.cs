namespace Excalibur
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFistname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFistname
            // 
            this.lblFistname.AutoSize = true;
            this.lblFistname.Location = new System.Drawing.Point(13, 9);
            this.lblFistname.Name = "lblFistname";
            this.lblFistname.Size = new System.Drawing.Size(48, 13);
            this.lblFistname.TabIndex = 2;
            this.lblFistname.Text = "Förnamn";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(16, 30);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(140, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(162, 30);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(140, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(159, 9);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(55, 13);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Efternamn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 331);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFistname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFistname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
    }
}

