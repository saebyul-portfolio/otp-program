namespace otp_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" || pwdBox.Text == "")
            {
                MessageBox.Show("아이디 혹은 패스워드가 누락되었습니다.");
                return;
            } else
            {
                new Form2().ShowDialog();
            }
        }
    }
}