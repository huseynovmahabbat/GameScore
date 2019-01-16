namespace MiniFootball.Forms
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datebirth = new System.Windows.Forms.DateTimePicker();
            this.txbx_cpwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_pwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(59, 149);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(195, 20);
            this.txbx_name.TabIndex = 1;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(149, 571);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(105, 42);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(59, 214);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(195, 20);
            this.txbx_surname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname :";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(59, 289);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.Size = new System.Drawing.Size(195, 20);
            this.txbx_email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birth Date :";
            // 
            // dtp_datebirth
            // 
            this.dtp_datebirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datebirth.Location = new System.Drawing.Point(59, 366);
            this.dtp_datebirth.Name = "dtp_datebirth";
            this.dtp_datebirth.Size = new System.Drawing.Size(195, 20);
            this.dtp_datebirth.TabIndex = 8;
            // 
            // txbx_cpwd
            // 
            this.txbx_cpwd.Location = new System.Drawing.Point(59, 514);
            this.txbx_cpwd.Name = "txbx_cpwd";
            this.txbx_cpwd.Size = new System.Drawing.Size(195, 20);
            this.txbx_cpwd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm Password :";
            // 
            // txbx_pwd
            // 
            this.txbx_pwd.Location = new System.Drawing.Point(59, 439);
            this.txbx_pwd.Name = "txbx_pwd";
            this.txbx_pwd.Size = new System.Drawing.Size(195, 20);
            this.txbx_pwd.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password :";
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.Location = new System.Drawing.Point(12, 9);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 13);
            this.lbl_errors.TabIndex = 13;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 623);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.txbx_cpwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbx_pwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_datebirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txbx_name);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datebirth;
        private System.Windows.Forms.TextBox txbx_cpwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_pwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_errors;
    }
}