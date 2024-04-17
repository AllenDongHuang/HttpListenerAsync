
namespace WFHttpServer
{
    partial class FrmServer
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
            this.txtIPAddress1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblListen = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtIPAddress2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "监听地址1";
            // 
            // txtIPAddress1
            // 
            this.txtIPAddress1.Location = new System.Drawing.Point(135, 74);
            this.txtIPAddress1.Name = "txtIPAddress1";
            this.txtIPAddress1.Size = new System.Drawing.Size(336, 28);
            this.txtIPAddress1.TabIndex = 1;
            this.txtIPAddress1.Text = "http://127.0.0.1:8033/";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(172, 251);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开启监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblListen
            // 
            this.lblListen.AutoSize = true;
            this.lblListen.Location = new System.Drawing.Point(131, 192);
            this.lblListen.Name = "lblListen";
            this.lblListen.Size = new System.Drawing.Size(89, 18);
            this.lblListen.TabIndex = 3;
            this.lblListen.Text = "lblListen";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭监听";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtIPAddress2
            // 
            this.txtIPAddress2.Location = new System.Drawing.Point(135, 132);
            this.txtIPAddress2.Name = "txtIPAddress2";
            this.txtIPAddress2.Size = new System.Drawing.Size(336, 28);
            this.txtIPAddress2.TabIndex = 1;
            this.txtIPAddress2.Text = "http://127.0.0.1:8022/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "监听地址2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(134, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "注意！ 监听地址必须以 / 正斜杠结尾";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblListen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIPAddress2);
            this.Controls.Add(this.txtIPAddress1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HttpServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblListen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtIPAddress2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

