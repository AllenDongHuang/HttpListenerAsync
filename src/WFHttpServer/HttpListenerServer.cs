using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Lair.HttpListener;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;


namespace WFHttpServer
{
    /// <summary>
    ///  通过HttpListener实现简单的http服务器
    /// </summary>
    public class HttpListenerServer : IListenerHandler
    {
        public void HandleException(Exception exception)
        {
            Rect rect = new Rect();
            Console.Error.WriteLine(exception);
        }

        public Task Process(HttpListenerContext context)
        {
            Stream outputStream = context.Response.OutputStream;

            string resp = "Hello world!";
            byte[] buffer = Encoding.UTF8.GetBytes(resp);
            outputStream.Write(buffer, 0, buffer.Length);
            outputStream.Close();
            context.Response.StatusCode = 200;
            context.Response.StatusDescription = "OK";

            context.Response.Close();

            HttpListenerRequest request = context.Request;
            switch (request.HttpMethod)
            {

            }

            return Task.FromResult(true);
        }

        /// <summary>
        /// 启动监听
        /// </summary>
        /// <param name="prefixes">监听的多个地址</param>
        public void Start(AsyncHttpListener _listener, string[] prefixes)
        {

            // 增加监听的前缀
            //foreach (string s in prefixes)
            //{
            //    Console.WriteLine("hd"+s);
            //    //_listener.Prefixes.Add(s);
            //    _listener.Initialize(s, 5000);
            //}
            _listener.Initialize(prefixes, 5000);

            Console.WriteLine("hd 1");
            _listener.Start(); //开始监听
            //_listener.BeginGetContext(GetContextCallBack, _listener);
        }

        private void GetContextCallBack(IAsyncResult ar)
        {
            Console.WriteLine("hd 2");
            try
            {
                HttpListener _listener = ar.AsyncState as HttpListener;
                if (_listener.IsListening)
                {
                    HttpListenerContext context = _listener.EndGetContext(ar);
                    _listener.BeginGetContext(new AsyncCallback(GetContextCallBack), _listener);

                    #region 解析Request请求

                    HttpListenerRequest request = context.Request;
                    string content = "";
                    switch (request.HttpMethod)
                    {
                        case "POST":
                            {
                                Stream stream = context.Request.InputStream;
                                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                                content = reader.ReadToEnd();

                                //模拟接受的数据：将接收的字符串内容进行json反序列号为对象
                                TestValue tv = JsonConvert.DeserializeObject<TestValue>(content); 
                                //根据需求做相应操作
                            }
                            break;
                        case "GET":
                            {
                                var data = request.QueryString;
                            }
                            break;
                    }

                    #endregion

                    #region 构造Response响应

                    HttpListenerResponse response = context.Response; 
                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.ContentType = "application/json;charset=UTF-8";
                    response.ContentEncoding = Encoding.UTF8;
                    response.AppendHeader("Content-Type", "application/json;charset=UTF-8");

                    //模拟返回的数据：Json格式
                    var abcOject = new
                    {
                        code = "200",
                        description = "success",
                        data = "time=" + DateTime.Now
                    };
                    string responseString = JsonConvert.SerializeObject(abcOject,
                        new JsonSerializerSettings()
                        {
                            StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
                        });

                    using (StreamWriter writer = new StreamWriter(response.OutputStream, Encoding.UTF8))
                    {
                        writer.Write(responseString);
                        writer.Close();
                        response.Close();
                    }

                    #endregion

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }


    //用于json反序列化获取的测试实体类
    public class TestValue
    {
        public int id { get; set; }
        public string name { get; set; }
    }


}
