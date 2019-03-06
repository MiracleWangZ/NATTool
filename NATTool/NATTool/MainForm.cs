using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NATTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txt_DomainPrefix.Text = "NAT"+DateTime.Now.ToString("yyyyMMddHHmmss");
            txt_Port.Text = "8080";
        }

        string curDir = Environment.CurrentDirectory;
        private void btn_Pierced_Click(object sender, EventArgs e)
        {
            string domainPrefix = txt_DomainPrefix.Text;
            if (string.IsNullOrWhiteSpace(domainPrefix))
            {
                MessageBox.Show("域名前缀不能为空！");
                return;
            }
            string port = txt_Port.Text;
            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("端口号不能为空！");
                return;
            }
            KillProc("ding");
            System.Diagnostics.Process exe = new System.Diagnostics.Process();
            exe.StartInfo.FileName = curDir + @"\ding.exe";
            exe.StartInfo.Arguments = "-config=./ding.cfg -subdomain=" + domainPrefix + " " + port + "";
            exe.Start();
            txt_From.Text = "http://"+domainPrefix+".vaiwan.com";
            txt_To.Text = "http://127.0.0.1:"+port; 
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
    }
}
