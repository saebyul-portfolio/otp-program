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
                MessageBox.Show("���̵� Ȥ�� �н����尡 �����Ǿ����ϴ�.");
                return;
            } else
            {
                new Form2().ShowDialog();
            }
        }
    }
}