namespace NATTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DomainPrefix = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Pierced = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "域名前缀(唯一)：";
            // 
            // txt_DomainPrefix
            // 
            this.txt_DomainPrefix.Location = new System.Drawing.Point(139, 27);
            this.txt_DomainPrefix.Name = "txt_DomainPrefix";
            this.txt_DomainPrefix.Size = new System.Drawing.Size(194, 21);
            this.txt_DomainPrefix.TabIndex = 1;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(139, 71);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(194, 21);
            this.txt_Port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本地网站端口号：";
            // 
            // btn_Pierced
            // 
            this.btn_Pierced.Location = new System.Drawing.Point(139, 127);
            this.btn_Pierced.Name = "btn_Pierced";
            this.btn_Pierced.Size = new System.Drawing.Size(75, 23);
            this.btn_Pierced.TabIndex = 4;
            this.btn_Pierced.Text = "穿透";
            this.btn_Pierced.UseVisualStyleBackColor = true;
            this.btn_Pierced.Click += new System.EventHandler(this.btn_Pierced_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "转发：";
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(79, 165);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(254, 21);
            this.txt_From.TabIndex = 6;
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(79, 214);
            this.txt_To.Name = "txt_To";
            this.txt_To.ReadOnly = true;
            this.txt_To.Size = new System.Drawing.Size(254, 21);
            this.txt_To.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "->";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 263);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Pierced);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_DomainPrefix);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内网穿透";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DomainPrefix;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Pierced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label4;
    }
}

