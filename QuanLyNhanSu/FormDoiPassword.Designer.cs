namespace QuanLyNhanSu
{
    partial class FormDoiPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiPassword));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhauMoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận lại mật khẩu";
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(294, 44);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.PasswordChar = '*';
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(284, 22);
            this.txtMatKhauHienTai.TabIndex = 4;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(294, 120);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(284, 22);
            this.txtMatKhauMoi.TabIndex = 5;
            // 
            // txtXacNhanMatKhauMoi
            // 
            this.txtXacNhanMatKhauMoi.Location = new System.Drawing.Point(294, 188);
            this.txtXacNhanMatKhauMoi.Name = "txtXacNhanMatKhauMoi";
            this.txtXacNhanMatKhauMoi.PasswordChar = '*';
            this.txtXacNhanMatKhauMoi.Size = new System.Drawing.Size(284, 22);
            this.txtXacNhanMatKhauMoi.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.log_in_logout_session_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(295, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đồng ý";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::QuanLyNhanSu.Properties.Resources.cross_delete_remove_cancel_icon1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(496, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.computer_password_privacy_protection_security_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormDoiPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(609, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtXacNhanMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDoiPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanMatKhauMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}