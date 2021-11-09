﻿namespace otp_program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pwdBox = new System.Windows.Forms.RichTextBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idBox = new System.Windows.Forms.RichTextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(150, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(505, 86);
            this.title.TabIndex = 0;
            this.title.Text = "iOS OTP Project";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pwdBox);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(150, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 59);
            this.panel2.TabIndex = 3;
            // 
            // pwdBox
            // 
            this.pwdBox.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwdBox.Location = new System.Drawing.Point(0, 0);
            this.pwdBox.Multiline = false;
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(505, 59);
            this.pwdBox.TabIndex = 1;
            this.pwdBox.Text = "";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pwdLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pwdLabel.Location = new System.Drawing.Point(40, 251);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(90, 24);
            this.pwdLabel.TabIndex = 2;
            this.pwdLabel.Text = "비밀번호";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.idLabel.Location = new System.Drawing.Point(60, 188);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(70, 24);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "아이디";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.idBox);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(150, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 59);
            this.panel3.TabIndex = 4;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idBox.Location = new System.Drawing.Point(0, 0);
            this.idBox.Multiline = false;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(505, 59);
            this.idBox.TabIndex = 0;
            this.idBox.Text = "";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginLabel.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLabel.Location = new System.Drawing.Point(351, 315);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(110, 24);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "로그인하기";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(150, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 59);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Panel panel2;
        private Label pwdLabel;
        private Label idLabel;
        private Panel panel3;
        private RichTextBox pwdBox;
        private RichTextBox idBox;
        private Label loginLabel;
        private Button button1;
    }
}