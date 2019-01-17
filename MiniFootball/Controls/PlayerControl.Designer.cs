namespace MiniFootball.Controls
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_fullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_age = new System.Windows.Forms.TextBox();
            this.chb_selectplayer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbx_fullname
            // 
            this.txbx_fullname.Location = new System.Drawing.Point(30, 55);
            this.txbx_fullname.Name = "txbx_fullname";
            this.txbx_fullname.ReadOnly = true;
            this.txbx_fullname.Size = new System.Drawing.Size(214, 22);
            this.txbx_fullname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email :";
            // 
            // txbx_email
            // 
            this.txbx_email.Location = new System.Drawing.Point(281, 55);
            this.txbx_email.Name = "txbx_email";
            this.txbx_email.ReadOnly = true;
            this.txbx_email.Size = new System.Drawing.Size(214, 22);
            this.txbx_email.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age :";
            // 
            // txbx_age
            // 
            this.txbx_age.Location = new System.Drawing.Point(515, 55);
            this.txbx_age.Name = "txbx_age";
            this.txbx_age.ReadOnly = true;
            this.txbx_age.Size = new System.Drawing.Size(214, 22);
            this.txbx_age.TabIndex = 6;
            // 
            // chb_selectplayer
            // 
            this.chb_selectplayer.AutoSize = true;
            this.chb_selectplayer.Location = new System.Drawing.Point(3, 60);
            this.chb_selectplayer.Name = "chb_selectplayer";
            this.chb_selectplayer.Size = new System.Drawing.Size(18, 17);
            this.chb_selectplayer.TabIndex = 8;
            this.chb_selectplayer.UseVisualStyleBackColor = true;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chb_selectplayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_fullname);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(734, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbx_fullname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbx_email;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbx_age;
        public System.Windows.Forms.CheckBox chb_selectplayer;
    }
}
