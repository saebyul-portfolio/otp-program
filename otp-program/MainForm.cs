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
                MessageBox.Show("���̵� Ȥ�� �н����尡 �����Ǿ����ϴ�.");
                return;
            } else if(idBox.Text == "administrator" && pwdBox.Text == "password")
            {
                this.Hide();
                new OTPForm().ShowDialog();
            } else
            {
                MessageBox.Show("���̵� Ȥ�� �н����尡 ��ġ���� �ʽ��ϴ�.");
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