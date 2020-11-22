using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Fleck;

namespace cn.swu_acm.projects.sia.libs
{
    class webSocket
    {
        private string address, port;
        private IDictionary<string, IWebSocketConnection> dic_Sockets = new Dictionary<string, IWebSocketConnection>();
        public webSocket()
        {
            this.address = DefaultConfig.ServerAddr;
            this.port = DefaultConfig.ServerPort;
        }

        ~webSocket()
        {
            foreach (var item in dic_Sockets.Values)
            {
                if (item != null)
                {
                    item.Close();
                }
            }
        }

        public void Start()
        {
            WebSocketServer wssv = new WebSocketServer("ws://" + address + ":" + port);
            wssv.RestartAfterListenError = true;
            wssv.Start(socket =>
            {
                socket.OnOpen = () =>   //连接建立事件
                {
                    //获取客户端网页的url
                    string clientUrl = socket.ConnectionInfo.ClientIpAddress + ":" + socket.ConnectionInfo.ClientPort;
                    dic_Sockets.Add(clientUrl, socket);
                    Console.WriteLine(DateTime.Now.ToString() + "|服务器:和客户端网页:" + clientUrl + " 建立WebSock连接！");
                };
                socket.OnClose = () =>  //连接关闭事件
                {
                    string clientUrl = socket.ConnectionInfo.ClientIpAddress + ":" + socket.ConnectionInfo.ClientPort;
                    //如果存在这个客户端,那么对这个socket进行移除
                    if (dic_Sockets.ContainsKey(clientUrl))
                    {
                        dic_Sockets.Remove(clientUrl);
                    }
                };
                socket.OnMessage = message =>  //接受客户端网页消息事件
                {
                    string clientUrl = socket.ConnectionInfo.ClientIpAddress + ":" + socket.ConnectionInfo.ClientPort;
                    var t = new Task(() =>
                    {
                        Send(clientUrl, message);
                    });
                    t.Start();
                };
            });
            while(true)
            {

            }
        }
        private void Send(string clientUrl,string message)
        {
            ClientData clientData = new ClientData();
            clientData.ReadFromJson(message);
            Function function = FunctionSet.FindClientFunc(clientData.RequestFunc);

            //dic_Sockets[clientUrl].Send(respone);

        }
    }
}
