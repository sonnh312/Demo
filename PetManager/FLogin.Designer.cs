﻿namespace PetManager
{
    partial class FLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkCreateAcc = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnOut = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUN = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkCreateAcc);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.BtnOut);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 288);
            this.panel1.TabIndex = 0;
            // 
            // linkCreateAcc
            // 
            this.linkCreateAcc.AutoSize = true;
            this.linkCreateAcc.Location = new System.Drawing.Point(257, 184);
            this.linkCreateAcc.Name = "linkCreateAcc";
            this.linkCreateAcc.Size = new System.Drawing.Size(73, 13);
            this.linkCreateAcc.TabIndex = 4;
            this.linkCreateAcc.TabStop = true;
            this.linkCreateAcc.Text = "Tạo tài khoản";
            this.linkCreateAcc.Click += new System.EventHandler(this.linkCreateAcc_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(356, 184);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // BtnOut
            // 
            this.BtnOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOut.Location = new System.Drawing.Point(281, 140);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Size = new System.Drawing.Size(75, 23);
            this.BtnOut.TabIndex = 3;
            this.BtnOut.Text = "Thoát";
            this.BtnOut.UseVisualStyleBackColor = true;
            this.BtnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(189, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPass);
            this.panel3.Controls.Add(this.lblPass);
            this.panel3.Location = new System.Drawing.Point(93, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 45);
            this.panel3.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 12);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(177, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "1";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(3, 13);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 19);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Mật Khẩu";
            this.lblPass.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUN);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Location = new System.Drawing.Point(93, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 45);
            this.panel2.TabIndex = 0;
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(3, 13);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(87, 19);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Tài Khoản";
            this.lblUN.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "hs";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 288);
            this.Controls.Add(this.panel1);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button BtnOut;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkCreateAcc;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

