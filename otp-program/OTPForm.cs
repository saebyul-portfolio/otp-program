#pragma warning disable CS8602
#pragma warning disable CS8600
#pragma warning disable SYSLIB0014

using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Web;
using Nancy.Json;
using System.Text.Json.Nodes;

namespace otp_program
{
    public partial class OTPForm : Form
    {
        public OTPForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (idBox.Text == "")
            {
                MessageBox.Show("OTP 토큰을 입력해주세요.");
                return;
            }
            string url = @"http://localhost/check";

            
            var json = "{\"token\": \"" + idBox.Text + "\",\"program\":\"IDK\"}";
            dynamic data = JsonNode.Parse(json);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json"; 
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        JObject resultJson = JObject.Parse(result);
                        if (resultJson["success"].ToString() != "True")
                        {
                            var reason = resultJson["message"].ToString();
                            switch(reason)
                            {
                                case "This is not a valid token.":
                                    MessageBox.Show("OTP 토큰은 정수 6자리로 구성되어 있습니다.");
                                    break;
                                case "Unexpected Token":
                                    MessageBox.Show("올바른 OTP 토큰이 아닙니다.");
                                    break;
                                case "This token has already been used.":
                                    MessageBox.Show("이미 사용된 OTP 토큰입니다.");
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("로그인 성공");
                            this.Hide();
                            new finalForm().ShowDialog();
                        }
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void OTPFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
