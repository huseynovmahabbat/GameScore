namespace MiniFootball.Forms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbg_teamadd = new System.Windows.Forms.TabPage();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_estabdate = new System.Windows.Forms.DateTimePicker();
            this.btn_loadphoto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_adminpanel = new System.Windows.Forms.TabControl();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbg_teamadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbc_adminpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1133, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbg_teamadd
            // 
            this.tbg_teamadd.Controls.Add(this.btn_Add);
            this.tbg_teamadd.Controls.Add(this.label4);
            this.tbg_teamadd.Controls.Add(this.dtp_estabdate);
            this.tbg_teamadd.Controls.Add(this.btn_loadphoto);
            this.tbg_teamadd.Controls.Add(this.label3);
            this.tbg_teamadd.Controls.Add(this.pictureBox1);
            this.tbg_teamadd.Controls.Add(this.txbx_name);
            this.tbg_teamadd.Controls.Add(this.label1);
            this.tbg_teamadd.Location = new System.Drawing.Point(4, 25);
            this.tbg_teamadd.Name = "tbg_teamadd";
            this.tbg_teamadd.Padding = new System.Windows.Forms.Padding(3);
            this.tbg_teamadd.Size = new System.Drawing.Size(1133, 699);
            this.tbg_teamadd.TabIndex = 0;
            this.tbg_teamadd.Text = "Team Add";
            this.tbg_teamadd.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(785, 607);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(332, 86);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Establishment Date :";
            // 
            // dtp_estabdate
            // 
            this.dtp_estabdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_estabdate.Location = new System.Drawing.Point(29, 529);
            this.dtp_estabdate.Name = "dtp_estabdate";
            this.dtp_estabdate.Size = new System.Drawing.Size(305, 22);
            this.dtp_estabdate.TabIndex = 7;
            // 
            // btn_loadphoto
            // 
            this.btn_loadphoto.Location = new System.Drawing.Point(29, 384);
            this.btn_loadphoto.Name = "btn_loadphoto";
            this.btn_loadphoto.Size = new System.Drawing.Size(305, 86);
            this.btn_loadphoto.TabIndex = 6;
            this.btn_loadphoto.Text = "Load Photo";
            this.btn_loadphoto.UseVisualStyleBackColor = true;
            this.btn_loadphoto.Click += new System.EventHandler(this.btn_loadphoto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logo :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(29, 78);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(305, 22);
            this.txbx_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // tbc_adminpanel
            // 
            this.tbc_adminpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_adminpanel.Controls.Add(this.tbg_teamadd);
            this.tbc_adminpanel.Controls.Add(this.tabPage2);
            this.tbc_adminpanel.Location = new System.Drawing.Point(12, 23);
            this.tbc_adminpanel.Name = "tbc_adminpanel";
            this.tbc_adminpanel.SelectedIndex = 0;
            this.tbc_adminpanel.Size = new System.Drawing.Size(1141, 728);
            this.tbc_adminpanel.TabIndex = 0;
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.FileName = "openFileDialog1";
            this.openPhotoDialog.Filter = "\"JPG files (*.jpg)|*.jpg|PNG files (*.png*)|*.png|JPEG files (*.jpeg*)|*.jpeg\"";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 757);
            this.Controls.Add(this.tbc_adminpanel);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tbg_teamadd.ResumeLayout(false);
            this.tbg_teamadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbc_adminpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbg_teamadd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_estabdate;
        private System.Windows.Forms.Button btn_loadphoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbc_adminpanel;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
    }
}