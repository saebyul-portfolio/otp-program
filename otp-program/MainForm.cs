namespace otp_program
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" || pwdBox.Text == "")
            {
                MessageBox.Show("아이디 혹은 패스워드가 누락되었습니다.");
                return;
            } else if(idBox.Text == "administrator" && pwdBox.Text == "password")
            {
                this.Hide();
                new OTPForm().ShowDialog();
            } else
            {
                MessageBox.Show("아이디 혹은 패스워드가 일치하지 않습니다.");
                return;
            }
        }

        private void MainFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                pwdBox.PasswordChar = default(char);
            } else
            {
                pwdBox.PasswordChar = '*';
            }
        }
    }
}