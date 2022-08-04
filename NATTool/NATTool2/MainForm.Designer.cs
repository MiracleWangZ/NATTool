namespace NATTool2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Pierced = new System.Windows.Forms.Button();
            this.btn_Auth = new System.Windows.Forms.Button();
            this.cmb_AuthToken = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_From = new System.Windows.Forms.LinkLabel();
            this.linkLabel_To = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_PublicUrl = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(139, 73);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(163, 21);
            this.txt_Port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本地网站端口号：";
            // 
            // btn_Pierced
            // 
            this.btn_Pierced.Location = new System.Drawing.Point(334, 71);
            this.btn_Pierced.Name = "btn_Pierced";
            this.btn_Pierced.Size = new System.Drawing.Size(75, 23);
            this.btn_Pierced.TabIndex = 4;
            this.btn_Pierced.Text = "穿透";
            this.btn_Pierced.UseVisualStyleBackColor = true;
            this.btn_Pierced.Click += new System.EventHandler(this.btn_Pierced_Click);
            // 
            // btn_Auth
            // 
            this.btn_Auth.Location = new System.Drawing.Point(404, 10);
            this.btn_Auth.Name = "btn_Auth";
            this.btn_Auth.Size = new System.Drawing.Size(75, 23);
            this.btn_Auth.TabIndex = 9;
            this.btn_Auth.Text = "授权";
            this.btn_Auth.UseVisualStyleBackColor = true;
            this.btn_Auth.Click += new System.EventHandler(this.btn_Auth_Click);
            // 
            // cmb_AuthToken
            // 
            this.cmb_AuthToken.FormattingEnabled = true;
            this.cmb_AuthToken.Location = new System.Drawing.Point(65, 12);
            this.cmb_AuthToken.Name = "cmb_AuthToken";
            this.cmb_AuthToken.Size = new System.Drawing.Size(333, 20);
            this.cmb_AuthToken.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOKEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "资源有限，选择一个TOKEN，点击授权一次即可，如无法穿透，换个再来一次！";
            // 
            // linkLabel_From
            // 
            this.linkLabel_From.AutoSize = true;
            this.linkLabel_From.Location = new System.Drawing.Point(137, 109);
            this.linkLabel_From.Name = "linkLabel_From";
            this.linkLabel_From.Size = new System.Drawing.Size(131, 12);
            this.linkLabel_From.TabIndex = 13;
            this.linkLabel_From.TabStop = true;
            this.linkLabel_From.Text = "http://127.0.0.1:4040";
            this.linkLabel_From.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_From_LinkClicked);
            // 
            // linkLabel_To
            // 
            this.linkLabel_To.AutoSize = true;
            this.linkLabel_To.Location = new System.Drawing.Point(137, 156);
            this.linkLabel_To.Name = "linkLabel_To";
            this.linkLabel_To.Size = new System.Drawing.Size(131, 12);
            this.linkLabel_To.TabIndex = 14;
            this.linkLabel_To.TabStop = true;
            this.linkLabel_To.Text = "http://127.0.0.1:8080";
            this.linkLabel_To.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_From_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "网站界面：";
            // 
            // linkLabel_PublicUrl
            // 
            this.linkLabel_PublicUrl.AutoSize = true;
            this.linkLabel_PublicUrl.Location = new System.Drawing.Point(137, 132);
            this.linkLabel_PublicUrl.Name = "linkLabel_PublicUrl";
            this.linkLabel_PublicUrl.Size = new System.Drawing.Size(0, 12);
            this.linkLabel_PublicUrl.TabIndex = 16;
            this.linkLabel_PublicUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_From_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "转发：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 192);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel_PublicUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel_To);
            this.Controls.Add(this.linkLabel_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_AuthToken);
            this.Controls.Add(this.btn_Auth);
            this.Controls.Add(this.btn_Pierced);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Port);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内网穿透2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Pierced;
        private System.Windows.Forms.Button btn_Auth;
        private System.Windows.Forms.ComboBox cmb_AuthToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_From;
        private System.Windows.Forms.LinkLabel linkLabel_To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel_PublicUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

