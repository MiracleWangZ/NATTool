using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NATTool2
{
    public partial class MainForm : Form
    {
        public static string authtoken = ConfigurationManager.AppSettings["authtoken"];
        public MainForm()
        {
            InitializeComponent();
            txt_Port.Text = "8080";
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> tokens = authtoken.Replace("\r\n","").Split(',').ToList();
            foreach (var token in tokens)
            {
                cmb_AuthToken.Items.Add(token);
            }
        }

        string curDir = Environment.CurrentDirectory;
        private void btn_Pierced_Click(object sender, EventArgs e)
        {
            linkLabel_PublicUrl.Text = null;
            string port = txt_Port.Text;
            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("端口号不能为空！");
                return;
            }
            KillProc("ngrok");
            System.Diagnostics.Process exe = new System.Diagnostics.Process();
            exe.StartInfo.FileName = curDir + @"\ngrok.exe";
            exe.StartInfo.Arguments = "http "+ port;
           
            bool isOk = exe.Start();
            linkLabel_To.Text = "http://127.0.0.1:"+port;
            if (isOk)
            {
                while (string.IsNullOrWhiteSpace(linkLabel_PublicUrl.Text))
                {
                    GetNgrokUrl();
                }
            }
        }
        private void KillProc(string strProcName)
        {
            try
            {
                foreach (Process p in Process.GetProcessesByName(strProcName))
                {
                    p.Kill();
                }
            }
            catch
            {

            }
        }

        private void btn_Auth_Click(object sender, EventArgs e)
        {
            string token = cmb_AuthToken.Text;
            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("请选择一个TOKEN!");
                return;
            }
            KillProc("ngrok");
            System.Diagnostics.Process exe = new System.Diagnostics.Process();
            exe.StartInfo.FileName = curDir + @"\ngrok.exe";
            exe.StartInfo.Arguments = "authtoken " + token;
            exe.Start();
            MessageBox.Show("授权成功！");
        }

        private void linkLabel_From_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as LinkLabel).Text;
            System.Diagnostics.Process.Start(url);
        }

        private void GetNgrokUrl()
        {
            try
            {
                HttpWebRequest httpWebRequest = WebRequest.Create("http://127.0.0.1:4040/api/tunnels") as HttpWebRequest;
                HttpWebResponse httpWebRespones = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream stream = httpWebRespones.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
                string htmlString = streamReader.ReadToEnd();
                NgrokTunnel ngrokTunnel = JsonConvert.DeserializeObject<NgrokTunnel>(htmlString);
                linkLabel_PublicUrl.Text = ngrokTunnel.tunnels[0].public_url;
            }
            catch (Exception e)
            {
                
            }
            
        }
    }
}
