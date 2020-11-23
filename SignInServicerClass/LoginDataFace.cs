using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.swu_acm.projects.sia.libs
{
    /// <summary>
    /// 人脸登录的类
    /// </summary>
    class LoginDataFace : LoginData
    {
        private string photo_str;

        public string PhotoStr
        {
            get => photo_str;
            set => photo_str = value;
        }

        public LoginDataFace()
        {
            ServerAddr = DefaultConfig.ServerAddr;
            ServerPort = DefaultConfig.ServerPort;
            UserId = "000000000000000";
            PhotoStr = "";
            RequestFunc = Converter.EncodingTo32L(FunctionSetServer.LoginWithFace.ToString());
            CallBack = Converter.EncodingTo32L(FunctionSetClient.LoginFaceExpress.ToString());
        }
    }
}
