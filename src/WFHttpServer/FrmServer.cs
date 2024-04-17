using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lair.HttpListener;

namespace WFHttpServer
{
    public partial class FrmServer : Form
    {
        private AsyncHttpListener _listener;

        public FrmServer()
        {
            InitializeComponent();
        }

        #region 事件

        //开启监听
        private void btnStart_Click(object sender, EventArgs e)
        {
            //获取监听的多个地址
            string ipAddress1 = txtIPAddress1.Text.Trim();
            string ipAddress2 = txtIPAddress2.Text.Trim();

            // 注意前缀必须以 / 正斜杠结尾
            string[] prefixes = new string[] { ipAddress1, ipAddress2 };
            HttpListenerServer httpListenerServer = new HttpListenerServer();
            try
            {
                // 检查系统是否支持
                if (!HttpListener.IsSupported)
                {
                    throw new ArgumentException("使用 HttpListener 必须为 Windows XP SP2 或 Server 2003 以上系统！");
                }
                else
                { 
                    if (prefixes == null || prefixes.Length == 0)
                        throw new ArgumentException("缺少地址参数：prefixes");
                    else
                    {
                        //启动监听 // 创建监听器.
                        _listener = new AsyncHttpListener(httpListenerServer);
                        httpListenerServer.Start(_listener, prefixes);
                        lblListen.Text = "启用HttpListener监听成功！"; 
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            } 
        }

        //关闭监听
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_listener != null)
            {
                _listener.Stop();
                lblListen.Text = "停止HttpListener监听成功！"; 
            }
        }

        #endregion
    }
}
