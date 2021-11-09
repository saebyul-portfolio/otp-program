using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Net.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Web;
using Nancy.Json;
using System.Text.Json.Nodes;

namespace otp_program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Body에 데이터를 못 보냄
        private void button1_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("OTP 토큰을 입력해주세요.");
                return;
            }
            string url = @"http://localhost/check";


            var json = "{\"token\": \"" + idBox.Text + "\",\"program\":\"IDK\"}";
            dynamic data = JsonValue.Parse(json);

            MessageBox.Show(data.ToString());

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data.ToString());
                streamWriter.Flush();
                streamWriter.Close();
                try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        MessageBox.Show(result);
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
