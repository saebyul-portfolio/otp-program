namespace otp_program
{
    partial class MainForm
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
            this.pwdLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pwdLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pwdLabel.Location = new System.Drawing.Point(40, 192);
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
            this.idLabel.Location = new System.Drawing.Point(60, 163);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(70, 24);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "아이디";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginLabel.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLabel.Location = new System.Drawing.Point(354, 237);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(110, 24);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "로그인하기";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(153, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(505, 59);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pwdBox
            // 
            this.pwdBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pwdBox.Location = new System.Drawing.Point(153, 193);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '*';
            this.pwdBox.Size = new System.Drawing.Size(502, 23);
            this.pwdBox.TabIndex = 7;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idBox.Location = new System.Drawing.Point(153, 164);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(502, 23);
            this.idBox.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(153, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "비밀번호 보이기";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Label pwdLabel;
        private Label idLabel;
        private Label loginLabel;
        private Button button1;
        private TextBox pwdBox;
        private TextBox idBox;
        private CheckBox checkBox1;
    }
}